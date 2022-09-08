namespace Aplicatie_Concediu
{
    partial class Tabel_Concedii
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabel_Concedii));
            this.breakingBreadDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breakingBreadDataSet = new Aplicatie_Concediu.BreakingBreadDataSet();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.cbStariConcedii = new System.Windows.Forms.ComboBox();
            this.stareConcediuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stareConcediuTableAdapter = new Aplicatie_Concediu.BreakingBreadDataSetTableAdapters.StareConcediuTableAdapter();
            this.lStareConcediu = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.labelNumeUtilizatorLogat = new System.Windows.Forms.Label();
            this.pictureBoxUtilizatorLogat = new System.Windows.Forms.PictureBox();
            this.labelDeconectare = new System.Windows.Forms.Label();
            this.buttonIstoricConcedii = new System.Windows.Forms.Button();
            this.buttonPanouAdmin = new System.Windows.Forms.Button();
            this.buttonDetaliiAngajati = new System.Windows.Forms.Button();
            this.buttonCerereConcediu = new System.Windows.Forms.Button();
            this.buttonPaginaMea = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPanouAdmin = new System.Windows.Forms.Label();
            this.dgvTabelConcedii = new System.Windows.Forms.DataGridView();
            this.tbFiltrareNume = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stareConcediuBindingSource)).BeginInit();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatorLogat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelConcedii)).BeginInit();
            this.SuspendLayout();
            // 
            // breakingBreadDataSetBindingSource
            // 
            this.breakingBreadDataSetBindingSource.DataSource = this.breakingBreadDataSet;
            this.breakingBreadDataSetBindingSource.Position = 0;
            // 
            // breakingBreadDataSet
            // 
            this.breakingBreadDataSet.DataSetName = "BreakingBreadDataSet";
            this.breakingBreadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // cbStariConcedii
            // 
            this.cbStariConcedii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStariConcedii.FormattingEnabled = true;
            this.cbStariConcedii.Location = new System.Drawing.Point(247, 181);
            this.cbStariConcedii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStariConcedii.Name = "cbStariConcedii";
            this.cbStariConcedii.Size = new System.Drawing.Size(276, 33);
            this.cbStariConcedii.TabIndex = 6;
            this.cbStariConcedii.SelectionChangeCommitted += new System.EventHandler(this.cbStariConcedii_SelectionChangeCommitted);
            // 
            // stareConcediuBindingSource
            // 
            this.stareConcediuBindingSource.DataMember = "StareConcediu";
            this.stareConcediuBindingSource.DataSource = this.breakingBreadDataSetBindingSource;
            // 
            // stareConcediuTableAdapter
            // 
            this.stareConcediuTableAdapter.ClearBeforeFill = true;
            // 
            // lStareConcediu
            // 
            this.lStareConcediu.AutoSize = true;
            this.lStareConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStareConcediu.ForeColor = System.Drawing.Color.Peru;
            this.lStareConcediu.Location = new System.Drawing.Point(54, 181);
            this.lStareConcediu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.lStareConcediu.Name = "lStareConcediu";
            this.lStareConcediu.Size = new System.Drawing.Size(185, 29);
            this.lStareConcediu.TabIndex = 7;
            this.lStareConcediu.Text = "Stare Concediu:";
            // 
            // panelBackground
            // 
            this.panelBackground.AutoSize = true;
            this.panelBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(111)))));
            this.panelBackground.Controls.Add(this.pictureBoxLogo);
            this.panelBackground.Controls.Add(this.buttonIesire);
            this.panelBackground.Controls.Add(this.tableLayoutPanel1);
            this.panelBackground.Controls.Add(this.buttonIstoricConcedii);
            this.panelBackground.Controls.Add(this.buttonPanouAdmin);
            this.panelBackground.Controls.Add(this.buttonDetaliiAngajati);
            this.panelBackground.Controls.Add(this.buttonCerereConcediu);
            this.panelBackground.Controls.Add(this.buttonPaginaMea);
            this.panelBackground.Controls.Add(this.panel1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(50);
            this.panelBackground.Size = new System.Drawing.Size(1387, 788);
            this.panelBackground.TabIndex = 46;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(50, 9);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(211, 228);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 45;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonIesire
            // 
            this.buttonIesire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIesire.ForeColor = System.Drawing.Color.Peru;
            this.buttonIesire.Location = new System.Drawing.Point(1292, 50);
            this.buttonIesire.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(45, 39);
            this.buttonIesire.TabIndex = 37;
            this.buttonIesire.Text = "X";
            this.buttonIesire.UseVisualStyleBackColor = false;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.22946F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.77054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tableLayoutPanel1.Controls.Add(this.labelSeparator, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNumeUtilizatorLogat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxUtilizatorLogat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDeconectare, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(769, 114);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 76);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // labelSeparator
            // 
            this.labelSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeparator.AutoSize = true;
            this.labelSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeparator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSeparator.Location = new System.Drawing.Point(299, 0);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(26, 76);
            this.labelSeparator.TabIndex = 38;
            this.labelSeparator.Text = "|";
            this.labelSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumeUtilizatorLogat
            // 
            this.labelNumeUtilizatorLogat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumeUtilizatorLogat.AutoSize = true;
            this.labelNumeUtilizatorLogat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeUtilizatorLogat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNumeUtilizatorLogat.Location = new System.Drawing.Point(71, 0);
            this.labelNumeUtilizatorLogat.Name = "labelNumeUtilizatorLogat";
            this.labelNumeUtilizatorLogat.Size = new System.Drawing.Size(222, 76);
            this.labelNumeUtilizatorLogat.TabIndex = 37;
            this.labelNumeUtilizatorLogat.Text = "Nume Utilizator";
            this.labelNumeUtilizatorLogat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNumeUtilizatorLogat.Click += new System.EventHandler(this.labelNumeUtilizatorLogat_Click);
            // 
            // pictureBoxUtilizatorLogat
            // 
            this.pictureBoxUtilizatorLogat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUtilizatorLogat.Enabled = false;
            this.pictureBoxUtilizatorLogat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUtilizatorLogat.Image")));
            this.pictureBoxUtilizatorLogat.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxUtilizatorLogat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUtilizatorLogat.Name = "pictureBoxUtilizatorLogat";
            this.pictureBoxUtilizatorLogat.Size = new System.Drawing.Size(62, 72);
            this.pictureBoxUtilizatorLogat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUtilizatorLogat.TabIndex = 36;
            this.pictureBoxUtilizatorLogat.TabStop = false;
            this.pictureBoxUtilizatorLogat.Click += new System.EventHandler(this.pictureBoxUtilizatorLogat_Click);
            // 
            // labelDeconectare
            // 
            this.labelDeconectare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeconectare.AutoSize = true;
            this.labelDeconectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeconectare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDeconectare.Location = new System.Drawing.Point(331, 0);
            this.labelDeconectare.Name = "labelDeconectare";
            this.labelDeconectare.Size = new System.Drawing.Size(234, 76);
            this.labelDeconectare.TabIndex = 36;
            this.labelDeconectare.Text = "Deconectare";
            this.labelDeconectare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDeconectare.Click += new System.EventHandler(this.labelDeconectare_Click);
            // 
            // buttonIstoricConcedii
            // 
            this.buttonIstoricConcedii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonIstoricConcedii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIstoricConcedii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIstoricConcedii.ForeColor = System.Drawing.Color.Peru;
            this.buttonIstoricConcedii.Location = new System.Drawing.Point(50, 430);
            this.buttonIstoricConcedii.Margin = new System.Windows.Forms.Padding(0, 0, 50, 25);
            this.buttonIstoricConcedii.Name = "buttonIstoricConcedii";
            this.buttonIstoricConcedii.Size = new System.Drawing.Size(211, 68);
            this.buttonIstoricConcedii.TabIndex = 19;
            this.buttonIstoricConcedii.Text = "Istoric Concedii";
            this.buttonIstoricConcedii.UseVisualStyleBackColor = false;
            this.buttonIstoricConcedii.Click += new System.EventHandler(this.buttonIstoricConcedii_Click);
            // 
            // buttonPanouAdmin
            // 
            this.buttonPanouAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.buttonPanouAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPanouAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPanouAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPanouAdmin.Location = new System.Drawing.Point(50, 618);
            this.buttonPanouAdmin.Margin = new System.Windows.Forms.Padding(0, 0, 50, 25);
            this.buttonPanouAdmin.Name = "buttonPanouAdmin";
            this.buttonPanouAdmin.Size = new System.Drawing.Size(211, 70);
            this.buttonPanouAdmin.TabIndex = 18;
            this.buttonPanouAdmin.Text = "Panou Admin";
            this.buttonPanouAdmin.UseVisualStyleBackColor = false;
            this.buttonPanouAdmin.Visible = false;
            this.buttonPanouAdmin.Click += new System.EventHandler(this.buttonPanouAdmin_Click);
            // 
            // buttonDetaliiAngajati
            // 
            this.buttonDetaliiAngajati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonDetaliiAngajati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetaliiAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetaliiAngajati.ForeColor = System.Drawing.Color.Peru;
            this.buttonDetaliiAngajati.Location = new System.Drawing.Point(50, 523);
            this.buttonDetaliiAngajati.Margin = new System.Windows.Forms.Padding(0, 0, 50, 25);
            this.buttonDetaliiAngajati.Name = "buttonDetaliiAngajati";
            this.buttonDetaliiAngajati.Size = new System.Drawing.Size(211, 70);
            this.buttonDetaliiAngajati.TabIndex = 17;
            this.buttonDetaliiAngajati.Text = "Detalii Angajati";
            this.buttonDetaliiAngajati.UseVisualStyleBackColor = false;
            this.buttonDetaliiAngajati.Visible = false;
            this.buttonDetaliiAngajati.Click += new System.EventHandler(this.buttonDetaliiAngajati_Click);
            // 
            // buttonCerereConcediu
            // 
            this.buttonCerereConcediu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonCerereConcediu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerereConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerereConcediu.ForeColor = System.Drawing.Color.Peru;
            this.buttonCerereConcediu.Location = new System.Drawing.Point(50, 335);
            this.buttonCerereConcediu.Margin = new System.Windows.Forms.Padding(0, 0, 50, 25);
            this.buttonCerereConcediu.Name = "buttonCerereConcediu";
            this.buttonCerereConcediu.Size = new System.Drawing.Size(211, 70);
            this.buttonCerereConcediu.TabIndex = 16;
            this.buttonCerereConcediu.Text = "Cerere Concediu";
            this.buttonCerereConcediu.UseVisualStyleBackColor = false;
            this.buttonCerereConcediu.Click += new System.EventHandler(this.buttonCerereConcediu_Click);
            // 
            // buttonPaginaMea
            // 
            this.buttonPaginaMea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonPaginaMea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaginaMea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaginaMea.ForeColor = System.Drawing.Color.Peru;
            this.buttonPaginaMea.Location = new System.Drawing.Point(50, 240);
            this.buttonPaginaMea.Margin = new System.Windows.Forms.Padding(0, 0, 50, 25);
            this.buttonPaginaMea.Name = "buttonPaginaMea";
            this.buttonPaginaMea.Size = new System.Drawing.Size(211, 70);
            this.buttonPaginaMea.TabIndex = 15;
            this.buttonPaginaMea.Text = "Pagina Mea";
            this.buttonPaginaMea.UseVisualStyleBackColor = false;
            this.buttonPaginaMea.Click += new System.EventHandler(this.buttonPaginaMea_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.cbStariConcedii);
            this.panel1.Controls.Add(this.lStareConcediu);
            this.panel1.Controls.Add(this.dgvTabelConcedii);
            this.panel1.Controls.Add(this.labelPanouAdmin);
            this.panel1.Location = new System.Drawing.Point(311, 240);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 75, 50, 50);
            this.panel1.Size = new System.Drawing.Size(1026, 498);
            this.panel1.TabIndex = 44;
            // 
            // labelPanouAdmin
            // 
            this.labelPanouAdmin.AutoSize = true;
            this.labelPanouAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.labelPanouAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanouAdmin.ForeColor = System.Drawing.Color.Peru;
            this.labelPanouAdmin.Location = new System.Drawing.Point(50, 75);
            this.labelPanouAdmin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 75);
            this.labelPanouAdmin.Name = "labelPanouAdmin";
            this.labelPanouAdmin.Size = new System.Drawing.Size(186, 31);
            this.labelPanouAdmin.TabIndex = 43;
            this.labelPanouAdmin.Text = "Panou Admin";
            // 
            // dgvTabelConcedii
            // 
            this.dgvTabelConcedii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabelConcedii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelConcedii.Location = new System.Drawing.Point(54, 264);
            this.dgvTabelConcedii.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTabelConcedii.Name = "dgvTabelConcedii";
            this.dgvTabelConcedii.RowHeadersWidth = 51;
            this.dgvTabelConcedii.Size = new System.Drawing.Size(918, 184);
            this.dgvTabelConcedii.TabIndex = 5;
            this.dgvTabelConcedii.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelConcedii_CellDoubleClick);
            // 
            // tbFiltrareNume
            // 
            this.tbFiltrareNume.Location = new System.Drawing.Point(13, 60);
            this.tbFiltrareNume.Name = "tbFiltrareNume";
            this.tbFiltrareNume.Size = new System.Drawing.Size(100, 20);
            this.tbFiltrareNume.TabIndex = 8;
            this.tbFiltrareNume.TextChanged += new System.EventHandler(this.tbFiltrareNume_TextChanged);
            this.tbFiltrareNume.Leave += new System.EventHandler(this.tbFiltrareNume_Leave);
            // 
            // Tabel_Concedii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientSize = new System.Drawing.Size(1122, 534);
            this.Controls.Add(this.tbFiltrareNume);
            this.Controls.Add(this.lStareConcediu);
            this.Controls.Add(this.cbStariConcedii);
            this.Controls.Add(this.dgvTabelConcedii);
            this.Name = "Tabel_Concedii";
            this.Text = "Tabel_Concedii";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tabel_Concedii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stareConcediuBindingSource)).EndInit();
            this.panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatorLogat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelConcedii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource breakingBreadDataSetBindingSource;
        private BreakingBreadDataSet breakingBreadDataSet;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox cbStariConcedii;
        private System.Windows.Forms.BindingSource stareConcediuBindingSource;
        private BreakingBreadDataSetTableAdapters.StareConcediuTableAdapter stareConcediuTableAdapter;
        private System.Windows.Forms.Label lStareConcediu;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonIesire;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.Label labelNumeUtilizatorLogat;
        private System.Windows.Forms.PictureBox pictureBoxUtilizatorLogat;
        private System.Windows.Forms.Label labelDeconectare;
        private System.Windows.Forms.Button buttonIstoricConcedii;
        private System.Windows.Forms.Button buttonPanouAdmin;
        private System.Windows.Forms.Button buttonDetaliiAngajati;
        private System.Windows.Forms.Button buttonCerereConcediu;
        private System.Windows.Forms.Button buttonPaginaMea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPanouAdmin;
        private System.Windows.Forms.DataGridView dgvTabelConcedii;
    }
}