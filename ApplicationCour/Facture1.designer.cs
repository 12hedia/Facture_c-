namespace ApplicationCour
{
    partial class Facture1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num_facture = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_client = new System.Windows.Forms.ComboBox();
            this.txt_code_client = new System.Windows.Forms.TextBox();
            this.txt_MF = new System.Windows.Forms.TextBox();
            this.txt_num_tel = new System.Windows.Forms.TextBox();
            this.txt_adresse = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_article = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_code_Article = new System.Windows.Forms.TextBox();
            this.txt_puhtva = new System.Windows.Forms.TextBox();
            this.txt_puttc = new System.Windows.Forms.TextBox();
            this.txt_ptttc = new System.Windows.Forms.TextBox();
            this.txt_tva = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Qte_disponible = new System.Windows.Forms.TextBox();
            this.txt_qte = new System.Windows.Forms.NumericUpDown();
            this.Ajouter_Au_DGV = new System.Windows.Forms.Button();
            this.Supprimer_Du_DGV = new System.Windows.Forms.Button();
            this.dg_Detail_Facture = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Enregistrer_Facture = new System.Windows.Forms.Button();
            this.txt_facture_HTVA = new System.Windows.Forms.TextBox();
            this.txt_Net_Payee = new System.Windows.Forms.TextBox();
            this.txt_Facture_TVA = new System.Windows.Forms.TextBox();
            this.Imprimer_Facture = new System.Windows.Forms.Button();
            this.txt_Timbre = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_date_facture = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detail_Facture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Valken", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Facture N° ";
            // 
            // txt_num_facture
            // 
            this.txt_num_facture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_num_facture.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_facture.Location = new System.Drawing.Point(476, 61);
            this.txt_num_facture.Name = "txt_num_facture";
            this.txt_num_facture.Size = new System.Drawing.Size(97, 32);
            this.txt_num_facture.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Matricule Fiscale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Numero Téléphone";
            // 
            // txt_client
            // 
            this.txt_client.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client.FormattingEnabled = true;
            this.txt_client.Location = new System.Drawing.Point(78, 38);
            this.txt_client.Name = "txt_client";
            this.txt_client.Size = new System.Drawing.Size(162, 25);
            this.txt_client.TabIndex = 2;
            this.txt_client.SelectedValueChanged += new System.EventHandler(this.Afficher_Detail_Client);
            // 
            // txt_code_client
            // 
            this.txt_code_client.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code_client.Location = new System.Drawing.Point(242, 38);
            this.txt_code_client.Name = "txt_code_client";
            this.txt_code_client.ReadOnly = true;
            this.txt_code_client.Size = new System.Drawing.Size(57, 25);
            this.txt_code_client.TabIndex = 3;
            // 
            // txt_MF
            // 
            this.txt_MF.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MF.Location = new System.Drawing.Point(471, 38);
            this.txt_MF.Name = "txt_MF";
            this.txt_MF.ReadOnly = true;
            this.txt_MF.Size = new System.Drawing.Size(167, 25);
            this.txt_MF.TabIndex = 4;
            // 
            // txt_num_tel
            // 
            this.txt_num_tel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_tel.Location = new System.Drawing.Point(471, 73);
            this.txt_num_tel.Name = "txt_num_tel";
            this.txt_num_tel.ReadOnly = true;
            this.txt_num_tel.Size = new System.Drawing.Size(167, 25);
            this.txt_num_tel.TabIndex = 6;
            // 
            // txt_adresse
            // 
            this.txt_adresse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adresse.Location = new System.Drawing.Point(78, 76);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.ReadOnly = true;
            this.txt_adresse.Size = new System.Drawing.Size(221, 60);
            this.txt_adresse.TabIndex = 5;
            this.txt_adresse.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txt_adresse);
            this.groupBox1.Controls.Add(this.txt_num_tel);
            this.groupBox1.Controls.Add(this.txt_MF);
            this.groupBox1.Controls.Add(this.txt_code_client);
            this.groupBox1.Controls.Add(this.txt_client);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(154, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Client";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(133, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Article";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(252, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Qte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "PUHTVA";
            // 
            // txt_article
            // 
            this.txt_article.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_article.FormattingEnabled = true;
            this.txt_article.Location = new System.Drawing.Point(80, 45);
            this.txt_article.Name = "txt_article";
            this.txt_article.Size = new System.Drawing.Size(162, 25);
            this.txt_article.TabIndex = 8;
            this.txt_article.SelectedValueChanged += new System.EventHandler(this.Afficher_Detail_Produit);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(451, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "PUTTC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(394, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "TVA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(546, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "PTTTC";
            // 
            // txt_code_Article
            // 
            this.txt_code_Article.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code_Article.Location = new System.Drawing.Point(19, 45);
            this.txt_code_Article.Name = "txt_code_Article";
            this.txt_code_Article.ReadOnly = true;
            this.txt_code_Article.Size = new System.Drawing.Size(57, 25);
            this.txt_code_Article.TabIndex = 7;
            // 
            // txt_puhtva
            // 
            this.txt_puhtva.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_puhtva.Location = new System.Drawing.Point(297, 45);
            this.txt_puhtva.Name = "txt_puhtva";
            this.txt_puhtva.ReadOnly = true;
            this.txt_puhtva.Size = new System.Drawing.Size(93, 25);
            this.txt_puhtva.TabIndex = 10;
            // 
            // txt_puttc
            // 
            this.txt_puttc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_puttc.Location = new System.Drawing.Point(437, 45);
            this.txt_puttc.Name = "txt_puttc";
            this.txt_puttc.ReadOnly = true;
            this.txt_puttc.Size = new System.Drawing.Size(93, 25);
            this.txt_puttc.TabIndex = 12;
            // 
            // txt_ptttc
            // 
            this.txt_ptttc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ptttc.Location = new System.Drawing.Point(534, 45);
            this.txt_ptttc.Name = "txt_ptttc";
            this.txt_ptttc.ReadOnly = true;
            this.txt_ptttc.Size = new System.Drawing.Size(93, 25);
            this.txt_ptttc.TabIndex = 13;
            // 
            // txt_tva
            // 
            this.txt_tva.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tva.Location = new System.Drawing.Point(395, 45);
            this.txt_tva.Name = "txt_tva";
            this.txt_tva.ReadOnly = true;
            this.txt_tva.Size = new System.Drawing.Size(36, 25);
            this.txt_tva.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txt_Qte_disponible);
            this.groupBox2.Controls.Add(this.txt_qte);
            this.groupBox2.Controls.Add(this.txt_tva);
            this.groupBox2.Controls.Add(this.txt_ptttc);
            this.groupBox2.Controls.Add(this.txt_puttc);
            this.groupBox2.Controls.Add(this.txt_puhtva);
            this.groupBox2.Controls.Add(this.txt_code_Article);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_article);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(154, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 103);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Article";
            // 
            // txt_Qte_disponible
            // 
            this.txt_Qte_disponible.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qte_disponible.Location = new System.Drawing.Point(244, 75);
            this.txt_Qte_disponible.Name = "txt_Qte_disponible";
            this.txt_Qte_disponible.ReadOnly = true;
            this.txt_Qte_disponible.Size = new System.Drawing.Size(50, 22);
            this.txt_Qte_disponible.TabIndex = 15;
            // 
            // txt_qte
            // 
            this.txt_qte.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qte.Location = new System.Drawing.Point(244, 45);
            this.txt_qte.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_qte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_qte.Name = "txt_qte";
            this.txt_qte.Size = new System.Drawing.Size(50, 25);
            this.txt_qte.TabIndex = 14;
            this.txt_qte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_qte.ValueChanged += new System.EventHandler(this.Recalculer_Ligne);
            // 
            // Ajouter_Au_DGV
            // 
            this.Ajouter_Au_DGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ajouter_Au_DGV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter_Au_DGV.Location = new System.Drawing.Point(451, 364);
            this.Ajouter_Au_DGV.Name = "Ajouter_Au_DGV";
            this.Ajouter_Au_DGV.Size = new System.Drawing.Size(43, 35);
            this.Ajouter_Au_DGV.TabIndex = 14;
            this.Ajouter_Au_DGV.Text = "+";
            this.Ajouter_Au_DGV.UseVisualStyleBackColor = true;
            this.Ajouter_Au_DGV.Click += new System.EventHandler(this.Ajouter_Au_DGV_Click);
            // 
            // Supprimer_Du_DGV
            // 
            this.Supprimer_Du_DGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Supprimer_Du_DGV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer_Du_DGV.Location = new System.Drawing.Point(530, 364);
            this.Supprimer_Du_DGV.Name = "Supprimer_Du_DGV";
            this.Supprimer_Du_DGV.Size = new System.Drawing.Size(43, 35);
            this.Supprimer_Du_DGV.TabIndex = 15;
            this.Supprimer_Du_DGV.Text = "-";
            this.Supprimer_Du_DGV.UseVisualStyleBackColor = true;
            this.Supprimer_Du_DGV.Click += new System.EventHandler(this.Supprimer_Du_DGV_Click);
            // 
            // dg_Detail_Facture
            // 
            this.dg_Detail_Facture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dg_Detail_Facture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Detail_Facture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dg_Detail_Facture.Location = new System.Drawing.Point(78, 403);
            this.dg_Detail_Facture.Name = "dg_Detail_Facture";
            this.dg_Detail_Facture.Size = new System.Drawing.Size(765, 150);
            this.dg_Detail_Facture.TabIndex = 18;
            this.dg_Detail_Facture.DoubleClick += new System.EventHandler(this.Afficher_Detail_Ligne_Facture);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code Article";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Article";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PUHTVA";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qte";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "PTHTVA";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "TVA";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "PTTTC";
            this.Column7.Name = "Column7";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(585, 562);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Montant HTVA Facture";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(597, 588);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Montant TVA Facture";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(628, 638);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Montant Facture";
            // 
            // Enregistrer_Facture
            // 
            this.Enregistrer_Facture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Enregistrer_Facture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrer_Facture.Location = new System.Drawing.Point(450, 574);
            this.Enregistrer_Facture.Name = "Enregistrer_Facture";
            this.Enregistrer_Facture.Size = new System.Drawing.Size(102, 36);
            this.Enregistrer_Facture.TabIndex = 16;
            this.Enregistrer_Facture.Text = "Enregistrer";
            this.Enregistrer_Facture.UseVisualStyleBackColor = true;
            this.Enregistrer_Facture.Click += new System.EventHandler(this.Enregistrer_Facture_Click);
            // 
            // txt_facture_HTVA
            // 
            this.txt_facture_HTVA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_facture_HTVA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_facture_HTVA.Location = new System.Drawing.Point(750, 559);
            this.txt_facture_HTVA.Name = "txt_facture_HTVA";
            this.txt_facture_HTVA.ReadOnly = true;
            this.txt_facture_HTVA.Size = new System.Drawing.Size(93, 25);
            this.txt_facture_HTVA.TabIndex = 19;
            // 
            // txt_Net_Payee
            // 
            this.txt_Net_Payee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Net_Payee.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Net_Payee.Location = new System.Drawing.Point(750, 635);
            this.txt_Net_Payee.Name = "txt_Net_Payee";
            this.txt_Net_Payee.ReadOnly = true;
            this.txt_Net_Payee.Size = new System.Drawing.Size(93, 25);
            this.txt_Net_Payee.TabIndex = 22;
            // 
            // txt_Facture_TVA
            // 
            this.txt_Facture_TVA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Facture_TVA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Facture_TVA.Location = new System.Drawing.Point(750, 585);
            this.txt_Facture_TVA.Name = "txt_Facture_TVA";
            this.txt_Facture_TVA.ReadOnly = true;
            this.txt_Facture_TVA.Size = new System.Drawing.Size(93, 25);
            this.txt_Facture_TVA.TabIndex = 20;
            // 
            // Imprimer_Facture
            // 
            this.Imprimer_Facture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Imprimer_Facture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimer_Facture.Location = new System.Drawing.Point(450, 618);
            this.Imprimer_Facture.Name = "Imprimer_Facture";
            this.Imprimer_Facture.Size = new System.Drawing.Size(102, 36);
            this.Imprimer_Facture.TabIndex = 17;
            this.Imprimer_Facture.Text = "Imprimer";
            this.Imprimer_Facture.UseVisualStyleBackColor = true;
            this.Imprimer_Facture.Click += new System.EventHandler(this.Imprimer_Facture_Click);
            // 
            // txt_Timbre
            // 
            this.txt_Timbre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Timbre.AutoSize = true;
            this.txt_Timbre.Location = new System.Drawing.Point(754, 614);
            this.txt_Timbre.Name = "txt_Timbre";
            this.txt_Timbre.Size = new System.Drawing.Size(84, 17);
            this.txt_Timbre.TabIndex = 21;
            this.txt_Timbre.Text = "Droit Timbre";
            this.txt_Timbre.UseVisualStyleBackColor = true;
            this.txt_Timbre.CheckedChanged += new System.EventHandler(this.Changer_Valeur_Timbre);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(505, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 27);
            this.label15.TabIndex = 23;
            this.label15.Text = "Méthode N° 1";
            // 
            // txt_date_facture
            // 
            this.txt_date_facture.Location = new System.Drawing.Point(745, 73);
            this.txt_date_facture.Name = "txt_date_facture";
            this.txt_date_facture.Size = new System.Drawing.Size(200, 20);
            this.txt_date_facture.TabIndex = 24;
            // 
            // Facture1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.txt_date_facture);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_Timbre);
            this.Controls.Add(this.Imprimer_Facture);
            this.Controls.Add(this.txt_Facture_TVA);
            this.Controls.Add(this.txt_Net_Payee);
            this.Controls.Add(this.txt_facture_HTVA);
            this.Controls.Add(this.Enregistrer_Facture);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dg_Detail_Facture);
            this.Controls.Add(this.Supprimer_Du_DGV);
            this.Controls.Add(this.Ajouter_Au_DGV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_num_facture);
            this.Controls.Add(this.label1);
            this.Name = "Facture1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Methode 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detail_Facture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num_facture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_client;
        private System.Windows.Forms.TextBox txt_code_client;
        private System.Windows.Forms.TextBox txt_MF;
        private System.Windows.Forms.TextBox txt_num_tel;
        private System.Windows.Forms.RichTextBox txt_adresse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txt_article;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_code_Article;
        private System.Windows.Forms.TextBox txt_puhtva;
        private System.Windows.Forms.TextBox txt_puttc;
        private System.Windows.Forms.TextBox txt_ptttc;
        private System.Windows.Forms.TextBox txt_tva;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Ajouter_Au_DGV;
        private System.Windows.Forms.Button Supprimer_Du_DGV;
        private System.Windows.Forms.DataGridView dg_Detail_Facture;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Enregistrer_Facture;
        private System.Windows.Forms.TextBox txt_facture_HTVA;
        private System.Windows.Forms.TextBox txt_Net_Payee;
        private System.Windows.Forms.TextBox txt_Facture_TVA;
        private System.Windows.Forms.Button Imprimer_Facture;
        private System.Windows.Forms.CheckBox txt_Timbre;
        private System.Windows.Forms.TextBox txt_Qte_disponible;
        private System.Windows.Forms.NumericUpDown txt_qte;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DateTimePicker txt_date_facture;


    }
}

