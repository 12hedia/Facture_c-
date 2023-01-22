using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationCour
{
    public partial class Facture1 : Form
    {
        Outils o = new Outils();
        public Facture1()
        {
            InitializeComponent();
            o.Chargement_ComboBox_int("select code_client, nom_prenom from client order by nom_prenom", txt_client);
            o.Chargement_ComboBox_string("select code_article, nom_article from Article", txt_article);
        }

        private void Afficher_Detail_Client(object sender, EventArgs e)
        {
            txt_code_client.Text = txt_client.SelectedValue.ToString();
            txt_MF.Text = o.Select_Cellule("select Matricule_Fiscale from Client where Code_Client like '" + txt_client.SelectedValue.ToString() + "'");
            txt_adresse.Text = o.Select_Cellule("select Adresse from Client where Code_Client like '" + txt_client.SelectedValue.ToString() + "'");
            txt_num_tel.Text = o.Select_Cellule("select Num_Telephone from Client where Code_Client like '" + txt_client.SelectedValue.ToString() + "'");
        }

        private void Afficher_Detail_Produit(object sender, EventArgs e)
        {
            txt_code_Article.Text = txt_article.SelectedValue.ToString();
            
            txt_Qte_disponible.Text = o.Select_Cellule("Select Qte_Stock from Article where code_article like '" + txt_article.SelectedValue.ToString() + "'");
            double PUHTVA=Convert.ToDouble(o.Select_Cellule("Select PUHTVA from Article where code_article like '" + txt_article.SelectedValue.ToString() + "'"));
            txt_puhtva.Text = PUHTVA.ToString("0.000");
            double TVA = Convert.ToDouble(o.Select_Cellule("Select TVA from Article where code_article like '" + txt_article.SelectedValue.ToString() + "'"));
            txt_tva.Text = TVA.ToString();
            double PUTTC=PUHTVA*(1+(TVA/100));
            txt_puttc.Text=PUTTC.ToString("0.000");
            double QTE=Convert.ToDouble(txt_qte.Value);
            double PTTTC=QTE*PUTTC;
            txt_ptttc.Text=PTTTC.ToString("0.000");
            try
            {
                txt_qte.Minimum = 1;
                txt_qte.Maximum = Convert.ToDecimal(txt_Qte_disponible.Text);
            }
            catch
            {
                txt_qte.Minimum = 0;
                txt_qte.Maximum = 0;
            }
        }

        private void Recalculer_Ligne(object sender, EventArgs e)
        {
            double PUHTVA = Convert.ToDouble(o.Select_Cellule("Select PUHTVA from Article where code_article like '" + txt_article.SelectedValue.ToString() + "'"));
            double TVA = Convert.ToDouble(o.Select_Cellule("Select TVA from Article where code_article like '" + txt_article.SelectedValue.ToString() + "'"));
            double PUTTC = PUHTVA * (1 + (TVA / 100));
            double QTE = Convert.ToDouble(txt_qte.Value);
            double PTTTC = QTE * PUTTC;
            txt_ptttc.Text = PTTTC.ToString("0.000");

        }

        private void Calculer_Facture()
        {
            double FactureHTVA = 0;
            double FactureTTC = 0;
            for (int i = 0; i < dg_Detail_Facture.Rows.Count - 1; i++)
            {
                FactureHTVA += Convert.ToDouble(dg_Detail_Facture.Rows[i].Cells[4].Value);
                FactureTTC += Convert.ToDouble(dg_Detail_Facture.Rows[i].Cells[6].Value);
            }
            txt_facture_HTVA.Text = FactureHTVA.ToString("0.000");
            txt_Facture_TVA.Text = (FactureTTC - FactureHTVA).ToString("0.000");
            if (txt_Timbre.Checked == true)
                txt_Net_Payee.Text = (FactureTTC + 0.5).ToString("0.000");
            else
                txt_Net_Payee.Text = FactureTTC.ToString("0.000");
        }

        private void Ajouter_Au_DGV_Click(object sender, EventArgs e)
        {
            
           
            double PTHTVA = Convert.ToDouble(txt_puhtva.Text) * Convert.ToDouble(txt_qte.Value);
            dg_Detail_Facture.Rows.Add(txt_article.SelectedValue, txt_article.Text, txt_puhtva.Text, txt_qte.Value, PTHTVA.ToString("0.000"), txt_tva.Text.ToString(), txt_ptttc.Text);
            Calculer_Facture();

        }

        private void Supprimer_Du_DGV_Click(object sender, EventArgs e)
        {
            
            if(dg_Detail_Facture.Rows.Count>1)
                dg_Detail_Facture.Rows.Remove(dg_Detail_Facture.CurrentRow);
            Calculer_Facture();
        }

        private void Changer_Valeur_Timbre(object sender, EventArgs e)
        {
            Calculer_Facture();    
        }

        private void Enregistrer_Facture_Click(object sender, EventArgs e)
        {
            o.Execution_Requete("insert into Facture (Num_Facture,Date_Facture,Code_Client,Montant_HTVA_Facture,Montant_TVA_Facture,Droit_Timbre) values (" + txt_num_facture.Text + ",'" + txt_date_facture.Value + "'," + txt_client.SelectedValue + ",'" + txt_facture_HTVA.Text + "','" + txt_Facture_TVA.Text + "',"+txt_Timbre.Checked+");");
            for (int i = 0; i < dg_Detail_Facture.Rows.Count -1 ;i++ )
                o.Execution_Requete("insert into Ligne_Facture (Num_Facture,Code_Article,Qte,PUHTVA_Ligne_Facture,TVA) values (" + txt_num_facture.Text + ",'" + dg_Detail_Facture.Rows[i].Cells[0].Value + "'," + dg_Detail_Facture.Rows[i].Cells[3].Value + ",'" + dg_Detail_Facture.Rows[i].Cells[2].Value + "'," + dg_Detail_Facture.Rows[i].Cells[5].Value + ");");
            if (Convert.ToInt32(o.Select_Cellule("select count(*) from Ligne_facture where Num_Facture=" + txt_num_facture.Text)) == dg_Detail_Facture.Rows.Count-1)
                MessageBox.Show("Insertion avec succée");
            else
                MessageBox.Show("Erreur d'insertion");
        }

        private void Imprimer_Facture_Click(object sender, EventArgs e)
        {
            ImprimeFacture IF = new ImprimeFacture();
            IF.CC = txt_client.SelectedValue.ToString();
            IF.clt = txt_client.Text;
            IF.MF = txt_MF.Text;
            IF.adr = txt_adresse.Text;
            IF.df = txt_date_facture.Value.ToString();
            IF.NF = txt_num_facture.Text;
            IF.ShowDialog();
        }

        private void Afficher_Detail_Ligne_Facture(object sender, EventArgs e)
        {
            txt_article.SelectedValue = dg_Detail_Facture.CurrentRow.Cells[0].Value;
        }
    }
}
