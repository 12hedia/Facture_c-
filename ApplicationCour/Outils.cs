using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ApplicationCour
{
    class Outils
    {
        public string Convert_Point_Vergule(string chaine)
        {
            string resultat = "";
            for (int i = 0; i < chaine.Length; i++)
                if (chaine[i] == '.')
                    resultat = resultat + ',';
                else
                    resultat = resultat + chaine[i];
                return resultat;
        }

        public void Execution_Requete(string req)
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Facturation.accdb;";
            cn.Open();
            OleDbCommand cmd = new OleDbCommand(req, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Chargement_DataGridView(string req,DataGridView dg )
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Facturation.accdb;";
            cn.Open();
            OleDbDataAdapter cmd = new OleDbDataAdapter(req, cn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            cn.Close();
            dg.DataSource = dt;
        }

        public string Select_Cellule(string req)
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Facturation.accdb;";
            cn.Open();
            OleDbDataAdapter cmd = new OleDbDataAdapter(req, cn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            cn.Close();
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            else
                return null;
        }

        public void Chargement_ComboBox_int(string req, ComboBox cb)
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Facturation.accdb;";
            cn.Open();
            OleDbDataAdapter cmd = new OleDbDataAdapter(req, cn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            cn.Close();
            List<Element_int> L = new List<Element_int>();
            Element_int initial = new Element_int();
            L.Add(initial);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Element_int e = new Element_int();
                e.Identifiant = Convert.ToInt32(dt.Rows[i][0].ToString());
                e.NomElement = dt.Rows[i][1].ToString();
                L.Add(e);
            }
            cb.DataSource = L;
            cb.ValueMember = "Identifiant";
            cb.DisplayMember = "NomElement";

        }

        public void Chargement_ComboBox_string(string req, ComboBox cb)
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Facturation.accdb;";
            cn.Open();
            OleDbDataAdapter cmd = new OleDbDataAdapter(req, cn);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            cn.Close();
            List<Element_string> L = new List<Element_string>();
            Element_string initial = new Element_string();
            initial.Identifiant = "";
            initial.NomElement = "";
            L.Add(initial);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Element_string e = new Element_string();
                e.Identifiant = dt.Rows[i][0].ToString();
                e.NomElement = dt.Rows[i][1].ToString();
                L.Add(e);
            }
            cb.DataSource = L;
            cb.ValueMember = "Identifiant";
            cb.DisplayMember = "NomElement";

        }
    }
}
