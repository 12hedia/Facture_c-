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
    public partial class Facture3 : Form
    {
        Outils o = new Outils();
        public Facture3()
        {
            InitializeComponent();
            dg_Detail_Facture.CurrentCellChanged += new EventHandler(dg_Detail_Facture_CurrentCellChanged);
            o.Chargement_ComboBox_int("select code_client, nom_prenom from client order by nom_prenom", txt_client);
            Remplir_DataGridView();
        }

        void dg_Detail_Facture_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                double PUHTVA = Convert.ToDouble(dg_Detail_Facture.CurrentRow.Cells[2].Value);
                double QTE = Convert.ToDouble(dg_Detail_Facture.CurrentRow.Cells[3].Value);
                double TVA = Convert.ToDouble(dg_Detail_Facture.CurrentRow.Cells[5].Value);
                dg_Detail_Facture.CurrentRow.Cells[4].Value = (PUHTVA * QTE).ToString("0.000");
                dg_Detail_Facture.CurrentRow.Cells[6].Value = (PUHTVA * QTE * (1 + (TVA / 100))).ToString("0.000");
            }
            catch
            {

            }
            Calculer_Facture();
        }

        private void Afficher_Detail_Client(object sender, EventArgs e)
        {
            txt_code_client.Text = txt_client.SelectedValue.ToString();
            txt_MF.Text = o.Select_Cellule("select Matricule_Fiscale from Client where Code_Client like '" + txt_client.SelectedValue.ToString() + "'");
            txt_adresse.Text = o.Select_Cellule("select Adresse from Client where Code_Client like '" + txt_client.SelectedValue.ToString() + "'");
            txt_num_tel.Text = o.Select_Cellule("select Num_Telephone from Client where Code_Client like '" + txt_client.SelectedValue.ToString() + "'");
        }


        private void Remplir_DataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Code Article", Type.GetType("System.String"));
            dt.Columns.Add("Article", Type.GetType("System.String"));
            dt.Columns.Add("PUHTVA", Type.GetType("System.Double"));
            dt.Columns.Add("Qte", Type.GetType("System.Double"));
            dt.Columns.Add("PTHTVA", Type.GetType("System.Double"));
            dt.Columns.Add("TVA", Type.GetType("System.Double"));
            dt.Columns.Add("PTTTC", Type.GetType("System.Double"));
            
            dt.Columns[0].ReadOnly=true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;
            dt.Columns[4].ReadOnly = true;
            dt.Columns[5].ReadOnly = true;
            dt.Columns[6].ReadOnly = true;


            dg_Detail_Facture.DataSource = dt;
        }

        private void Ajouter_Ligne_DataGridView(DataRow DrNew)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Code Article", Type.GetType("System.String"));
            dt.Columns.Add("Article", Type.GetType("System.String"));
            dt.Columns.Add("PUHTVA", Type.GetType("System.Double"));
            dt.Columns.Add("Qte", Type.GetType("System.Int32"));
            dt.Columns.Add("PTHTVA", Type.GetType("System.Double"));
            dt.Columns.Add("TVA", Type.GetType("System.Int32"));
            dt.Columns.Add("PTTTC", Type.GetType("System.Double"));
            for (int i = 0; i < dg_Detail_Facture.Rows.Count-1; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0]=dg_Detail_Facture.Rows[i].Cells[0].Value;
                dr[1] = dg_Detail_Facture.Rows[i].Cells[1].Value;
                dr[2] = dg_Detail_Facture.Rows[i].Cells[2].Value;
                dr[3] = dg_Detail_Facture.Rows[i].Cells[3].Value;
                dr[4] = dg_Detail_Facture.Rows[i].Cells[4].Value;
                dr[5] = dg_Detail_Facture.Rows[i].Cells[5].Value;
                dr[6] = dg_Detail_Facture.Rows[i].Cells[6].Value;

                dt.Rows.Add(dr);
            }
            DataRow dr1 = dt.NewRow();
            dr1[0] = DrNew[0];
            dr1[1] = DrNew[1];
            dr1[2] = (Convert.ToDouble(DrNew[3])).ToString("0.000");
            dr1[3] = 1;
            dr1[4] = (Convert.ToDouble(DrNew[3])).ToString("0.000");;
            dr1[5] = DrNew[4];
            dr1[6] = (Convert.ToDouble(DrNew[5])).ToString("0.000"); ;
            dt.Rows.Add(dr1);
            dg_Detail_Facture.DataSource = dt;

            Calculer_Facture();
        }

        private void Modifier_Ligne_DataGridView(DataRow DrNew,int LigneNo)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Code Article", Type.GetType("System.String"));
            dt.Columns.Add("Article", Type.GetType("System.String"));
            dt.Columns.Add("PUHTVA", Type.GetType("System.Double"));
            dt.Columns.Add("Qte", Type.GetType("System.Int32"));
            dt.Columns.Add("PTHTVA", Type.GetType("System.Double"));
            dt.Columns.Add("TVA", Type.GetType("System.Int32"));
            dt.Columns.Add("PTTTC", Type.GetType("System.Double"));
            for (int i = 0; i < dg_Detail_Facture.Rows.Count - 1; i++)
            {
                if (LigneNo != i)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = dg_Detail_Facture.Rows[i].Cells[0].Value;
                    dr[1] = dg_Detail_Facture.Rows[i].Cells[1].Value;
                    dr[2] = dg_Detail_Facture.Rows[i].Cells[2].Value;
                    dr[3] = dg_Detail_Facture.Rows[i].Cells[3].Value;
                    dr[4] = dg_Detail_Facture.Rows[i].Cells[4].Value;
                    dr[5] = dg_Detail_Facture.Rows[i].Cells[5].Value;
                    dr[6] = dg_Detail_Facture.Rows[i].Cells[6].Value;
                    dt.Rows.Add(dr);
                }
                else
                {
                    DataRow dr1 = dt.NewRow();
                    dr1[0] = DrNew[0];
                    dr1[1] = DrNew[1];
                    dr1[2] = DrNew[3];
                    dr1[3] = 1;
                    dr1[4] = DrNew[3];
                    dr1[5] = DrNew[4];
                    dr1[6] = DrNew[5];
                    dt.Rows.Add(dr1);
                }
            }
            
            dg_Detail_Facture.DataSource = dt;

            Calculer_Facture();
        }

        private void Supprimer_Ligne_DataGridView()
        {
            int NumLigneSupprimer = dg_Detail_Facture.CurrentRow.Index;
            DataTable dt = new DataTable();
            dt.Columns.Add("Code Article", Type.GetType("System.String"));
            dt.Columns.Add("Article", Type.GetType("System.String"));
            dt.Columns.Add("PUHTVA", Type.GetType("System.Double"));
            dt.Columns.Add("Qte", Type.GetType("System.Int32"));
            dt.Columns.Add("PTHTVA", Type.GetType("System.Double"));
            dt.Columns.Add("TVA", Type.GetType("System.Int32"));
            dt.Columns.Add("PTTTC", Type.GetType("System.Double"));
            for (int i = 0; i < dg_Detail_Facture.Rows.Count - 1; i++)
            {
                if (i != NumLigneSupprimer)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = dg_Detail_Facture.Rows[i].Cells[0].Value;
                    dr[1] = dg_Detail_Facture.Rows[i].Cells[1].Value;
                    dr[2] = dg_Detail_Facture.Rows[i].Cells[2].Value;
                    dr[3] = dg_Detail_Facture.Rows[i].Cells[3].Value;
                    dr[4] = dg_Detail_Facture.Rows[i].Cells[4].Value;
                    dr[5] = dg_Detail_Facture.Rows[i].Cells[5].Value;
                    dr[6] = dg_Detail_Facture.Rows[i].Cells[6].Value;
                    dt.Rows.Add(dr);
                }
            }


            dg_Detail_Facture.DataSource = dt;
            Calculer_Facture();
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

        private void Changer_Valeur_Timbre(object sender, EventArgs e)
        {
            Calculer_Facture();    
        }

        private void Key_Down_DG(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                int row_selectionne = dg_Detail_Facture.CurrentRow.Index;
                ListeProduit lp = new ListeProduit();
                lp.ShowDialog();
                if (lp.CodeProduit != null)
                {
                    if (row_selectionne + 1 == dg_Detail_Facture.Rows.Count)
                    {
                        Ajouter_Ligne_DataGridView(lp.DrSeletionne);
                    }
                    else
                    {
                        Modifier_Ligne_DataGridView(lp.DrSeletionne, row_selectionne);
                    }
                }

            }
            if (e.KeyValue == 46)
            {
                Supprimer_Ligne_DataGridView();
            }
        }

        private void DoubleClick_Produit(object sender, EventArgs e)
        {
            int row_selectionne = dg_Detail_Facture.CurrentRow.Index;
            ListeProduit lp = new ListeProduit();
            lp.ShowDialog();
            if (lp.CodeProduit != null)
            {
                if (row_selectionne + 1 == dg_Detail_Facture.Rows.Count)
                {
                    Ajouter_Ligne_DataGridView(lp.DrSeletionne);
                }
                else
                {
                    Modifier_Ligne_DataGridView(lp.DrSeletionne, row_selectionne);
                }
            }
        }

        private void Enregistrer_Facture_Click(object sender, EventArgs e)
        {
            o.Execution_Requete("insert into Facture (Num_Facture,Date_Facture,Code_Client,Montant_HTVA_Facture,Montant_TVA_Facture,Droit_Timbre) values (" + txt_num_facture.Text + ",'" + txt_date_facture.Value + "'," + txt_client.SelectedValue + ",'" + txt_facture_HTVA.Text + "','" + txt_Facture_TVA.Text + "'," + txt_Timbre.Checked + ");");
            for (int i = 0; i < dg_Detail_Facture.Rows.Count - 1; i++)
                o.Execution_Requete("insert into Ligne_Facture (Num_Facture,Code_Article,Qte,PUHTVA_Ligne_Facture,TVA) values (" + txt_num_facture.Text + ",'" + dg_Detail_Facture.Rows[i].Cells[0].Value + "'," + dg_Detail_Facture.Rows[i].Cells[3].Value + ",'" + dg_Detail_Facture.Rows[i].Cells[2].Value + "'," + dg_Detail_Facture.Rows[i].Cells[5].Value + ");");
            if (Convert.ToInt32(o.Select_Cellule("select count(*) from Ligne_facture where Num_Facture=" + txt_num_facture.Text)) == dg_Detail_Facture.Rows.Count - 1)
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
    }
}
