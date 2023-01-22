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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void methode1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facture1 f1 = new Facture1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void methode2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facture2 f2 = new Facture2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void methode3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facture3 f3 = new Facture3();
            f3.MdiParent = this;
            f3.Show();
        }
    }
}
