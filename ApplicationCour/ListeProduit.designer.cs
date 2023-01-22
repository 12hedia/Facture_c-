namespace ApplicationCour
{
    partial class ListeProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_Produit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produit)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Produit
            // 
            this.dg_Produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Produit.Location = new System.Drawing.Point(29, 62);
            this.dg_Produit.Name = "dg_Produit";
            this.dg_Produit.Size = new System.Drawing.Size(713, 338);
            this.dg_Produit.TabIndex = 0;
            this.dg_Produit.DoubleClick += new System.EventHandler(this.DoubleClick_ChoisirProduit);
            this.dg_Produit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Press_Choisir_Produit);
            // 
            // ListeProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 442);
            this.Controls.Add(this.dg_Produit);
            this.Name = "ListeProduit";
            this.Text = "ListeProduit";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Produit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Produit;
    }
}