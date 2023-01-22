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
    public partial class ListeProduit : Form
    {
        Outils o = new Outils();
        public string CodeProduit = null;
        public DataRow DrSeletionne;
        public ListeProduit()
        {
            InitializeComponent();
            o.Chargement_DataGridView("SELECT Code_Article, Nom_Article, Qte_Stock, PUHTVA, TVA, ROUND(PUHTVA*(1+(TVA/100)),2) as PUTTC FROM Article", dg_Produit);

        }

        private void Key_Press_Choisir_Produit(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {

                CodeProduit=dg_Produit.CurrentRow.Cells[0].Value.ToString();
                DrSeletionne =((DataRowView)dg_Produit.CurrentRow.DataBoundItem).Row;
                this.Close();
            }
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void DoubleClick_ChoisirProduit(object sender, EventArgs e)
        {
            CodeProduit = dg_Produit.CurrentRow.Cells[0].Value.ToString();
            DrSeletionne = ((DataRowView)dg_Produit.CurrentRow.DataBoundItem).Row;
            this.Close();
        }
    }
}
