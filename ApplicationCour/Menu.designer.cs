namespace ApplicationCour
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.factureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methode1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methode2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methode3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // factureToolStripMenuItem
            // 
            this.factureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.methode1ToolStripMenuItem,
            this.methode2ToolStripMenuItem,
            this.methode3ToolStripMenuItem});
            this.factureToolStripMenuItem.Name = "factureToolStripMenuItem";
            this.factureToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.factureToolStripMenuItem.Text = "Facture";
            // 
            // methode1ToolStripMenuItem
            // 
            this.methode1ToolStripMenuItem.Name = "methode1ToolStripMenuItem";
            this.methode1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.methode1ToolStripMenuItem.Text = "Methode 1";
            this.methode1ToolStripMenuItem.Click += new System.EventHandler(this.methode1ToolStripMenuItem_Click);
            // 
            // methode2ToolStripMenuItem
            // 
            this.methode2ToolStripMenuItem.Name = "methode2ToolStripMenuItem";
            this.methode2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.methode2ToolStripMenuItem.Text = "Methode 2";
            this.methode2ToolStripMenuItem.Click += new System.EventHandler(this.methode2ToolStripMenuItem_Click);
            // 
            // methode3ToolStripMenuItem
            // 
            this.methode3ToolStripMenuItem.Name = "methode3ToolStripMenuItem";
            this.methode3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.methode3ToolStripMenuItem.Text = "Methode 3";
            this.methode3ToolStripMenuItem.Click += new System.EventHandler(this.methode3ToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 552);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem factureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methode1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methode2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methode3ToolStripMenuItem;
    }
}