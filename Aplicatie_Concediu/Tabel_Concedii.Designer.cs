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
            this.dgvTabelConcedii = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.cbStariConcedii = new System.Windows.Forms.ComboBox();
            this.stareConcediuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stareConcediuTableAdapter = new Aplicatie_Concediu.BreakingBreadDataSetTableAdapters.StareConcediuTableAdapter();
            this.lStareConcediu = new System.Windows.Forms.Label();
            this.tbFiltrareNume = new System.Windows.Forms.TextBox();
            this.dtpDataInceput = new System.Windows.Forms.DateTimePicker();
            this.lDataInceput = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lDataFinal = new System.Windows.Forms.Label();
            this.lNume = new System.Windows.Forms.Label();
            this.cbTipConcedii = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicaFiltre = new System.Windows.Forms.Button();
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
            this.panelContinut = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPageNumber = new System.Windows.Forms.Label();
            this.buttonPaginaAnterioara = new System.Windows.Forms.Button();
            this.buttonPaginaUrmatoare = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCereriConcediu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelConcedii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stareConcediuBindingSource)).BeginInit();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatorLogat)).BeginInit();
            this.panelContinut.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            // dgvTabelConcedii
            // 
            this.dgvTabelConcedii.AllowUserToAddRows = false;
            this.dgvTabelConcedii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabelConcedii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelConcedii.Location = new System.Drawing.Point(38, 258);
            this.dgvTabelConcedii.Margin = new System.Windows.Forms.Padding(0);
            this.dgvTabelConcedii.Name = "dgvTabelConcedii";
            this.dgvTabelConcedii.RowHeadersWidth = 51;
            this.dgvTabelConcedii.Size = new System.Drawing.Size(694, 38);
            this.dgvTabelConcedii.TabIndex = 5;
            this.dgvTabelConcedii.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelConcedii_CellDoubleClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // cbStariConcedii
            // 
            this.cbStariConcedii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStariConcedii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStariConcedii.FormattingEnabled = true;
            this.cbStariConcedii.Location = new System.Drawing.Point(549, 3);
            this.cbStariConcedii.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.cbStariConcedii.Name = "cbStariConcedii";
            this.cbStariConcedii.Size = new System.Drawing.Size(126, 24);
            this.cbStariConcedii.TabIndex = 6;
      
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
            this.lStareConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStareConcediu.ForeColor = System.Drawing.Color.Peru;
            this.lStareConcediu.Location = new System.Drawing.Point(463, 0);
            this.lStareConcediu.Name = "lStareConcediu";
            this.lStareConcediu.Size = new System.Drawing.Size(74, 60);
            this.lStareConcediu.TabIndex = 7;
            this.lStareConcediu.Text = "Stare Concediu:";
            // 
            // tbFiltrareNume
            // 
            this.tbFiltrareNume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltrareNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltrareNume.Location = new System.Drawing.Point(89, 3);
            this.tbFiltrareNume.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.tbFiltrareNume.Name = "tbFiltrareNume";
            this.tbFiltrareNume.Size = new System.Drawing.Size(122, 23);
            this.tbFiltrareNume.TabIndex = 8;
            this.tbFiltrareNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFiltrareNume_KeyPress);
            this.tbFiltrareNume.Leave += new System.EventHandler(this.tbFiltrareNume_Leave);
            // 
            // dtpDataInceput
            // 
            this.dtpDataInceput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataInceput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInceput.Location = new System.Drawing.Point(89, 64);
            this.dtpDataInceput.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.dtpDataInceput.Name = "dtpDataInceput";
            this.dtpDataInceput.Size = new System.Drawing.Size(122, 23);
            this.dtpDataInceput.TabIndex = 9;
            this.dtpDataInceput.ValueChanged += new System.EventHandler(this.dtpDataInceput_ValueChanged);
            // 
            // lDataInceput
            // 
            this.lDataInceput.AutoSize = true;
            this.lDataInceput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDataInceput.ForeColor = System.Drawing.Color.Peru;
            this.lDataInceput.Location = new System.Drawing.Point(3, 61);
            this.lDataInceput.Name = "lDataInceput";
            this.lDataInceput.Size = new System.Drawing.Size(75, 40);
            this.lDataInceput.TabIndex = 10;
            this.lDataInceput.Text = "Data Inceput:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Location = new System.Drawing.Point(319, 64);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(122, 23);
            this.dtpDataFinal.TabIndex = 11;
            this.dtpDataFinal.ValueChanged += new System.EventHandler(this.dtpDataFinal_ValueChanged);
            // 
            // lDataFinal
            // 
            this.lDataFinal.AutoSize = true;
            this.lDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDataFinal.ForeColor = System.Drawing.Color.Peru;
            this.lDataFinal.Location = new System.Drawing.Point(233, 61);
            this.lDataFinal.Name = "lDataFinal";
            this.lDataFinal.Size = new System.Drawing.Size(53, 40);
            this.lDataFinal.TabIndex = 12;
            this.lDataFinal.Text = "Data Final:";
            // 
            // lNume
            // 
            this.lNume.AutoSize = true;
            this.lNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNume.ForeColor = System.Drawing.Color.Peru;
            this.lNume.Location = new System.Drawing.Point(3, 0);
            this.lNume.Name = "lNume";
            this.lNume.Size = new System.Drawing.Size(60, 20);
            this.lNume.TabIndex = 13;
            this.lNume.Text = "Nume:";
            // 
            // cbTipConcedii
            // 
            this.cbTipConcedii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipConcedii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipConcedii.FormattingEnabled = true;
            this.cbTipConcedii.Location = new System.Drawing.Point(319, 3);
            this.cbTipConcedii.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.cbTipConcedii.Name = "cbTipConcedii";
            this.cbTipConcedii.Size = new System.Drawing.Size(122, 24);
            this.cbTipConcedii.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(233, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 60);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tip Concediu:";
            // 
            // btnAplicaFiltre
            // 
            this.btnAplicaFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicaFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.btnAplicaFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicaFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicaFiltre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAplicaFiltre.Location = new System.Drawing.Point(549, 64);
            this.btnAplicaFiltre.Margin = new System.Windows.Forms.Padding(3, 3, 19, 3);
            this.btnAplicaFiltre.Name = "btnAplicaFiltre";
            this.btnAplicaFiltre.Size = new System.Drawing.Size(126, 34);
            this.btnAplicaFiltre.TabIndex = 16;
            this.btnAplicaFiltre.Text = "Aplica";
            this.btnAplicaFiltre.UseVisualStyleBackColor = false;
            this.btnAplicaFiltre.Click += new System.EventHandler(this.btnAplicaFiltre_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.AutoSize = true;
            this.panelBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBackground.Controls.Add(this.pictureBoxLogo);
            this.panelBackground.Controls.Add(this.buttonIesire);
            this.panelBackground.Controls.Add(this.tableLayoutPanel1);
            this.panelBackground.Controls.Add(this.buttonIstoricConcedii);
            this.panelBackground.Controls.Add(this.buttonPanouAdmin);
            this.panelBackground.Controls.Add(this.buttonDetaliiAngajati);
            this.panelBackground.Controls.Add(this.buttonCerereConcediu);
            this.panelBackground.Controls.Add(this.buttonPaginaMea);
            this.panelBackground.Controls.Add(this.panelContinut);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(38, 41, 38, 41);
            this.panelBackground.Size = new System.Drawing.Size(1040, 640);
            this.panelBackground.TabIndex = 39;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(38, 7);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(158, 185);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonIesire
            // 
            this.buttonIesire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIesire.ForeColor = System.Drawing.Color.Peru;
            this.buttonIesire.Location = new System.Drawing.Point(968, 41);
            this.buttonIesire.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(34, 32);
            this.buttonIesire.TabIndex = 37;
            this.buttonIesire.Text = "X";
            this.buttonIesire.UseVisualStyleBackColor = false;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.22946F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.77054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel1.Controls.Add(this.labelSeparator, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNumeUtilizatorLogat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxUtilizatorLogat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDeconectare, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(573, 94);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 62);
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
            this.labelSeparator.Location = new System.Drawing.Point(210, 0);
            this.labelSeparator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(20, 62);
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
            this.labelNumeUtilizatorLogat.Location = new System.Drawing.Point(50, 0);
            this.labelNumeUtilizatorLogat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeUtilizatorLogat.Name = "labelNumeUtilizatorLogat";
            this.labelNumeUtilizatorLogat.Size = new System.Drawing.Size(156, 62);
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
            this.pictureBoxUtilizatorLogat.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxUtilizatorLogat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxUtilizatorLogat.Name = "pictureBoxUtilizatorLogat";
            this.pictureBoxUtilizatorLogat.Size = new System.Drawing.Size(44, 58);
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
            this.labelDeconectare.Location = new System.Drawing.Point(234, 0);
            this.labelDeconectare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeconectare.Name = "labelDeconectare";
            this.labelDeconectare.Size = new System.Drawing.Size(193, 62);
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
            this.buttonIstoricConcedii.Location = new System.Drawing.Point(38, 351);
            this.buttonIstoricConcedii.Margin = new System.Windows.Forms.Padding(0, 0, 38, 20);
            this.buttonIstoricConcedii.Name = "buttonIstoricConcedii";
            this.buttonIstoricConcedii.Size = new System.Drawing.Size(158, 55);
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
            this.buttonPanouAdmin.Location = new System.Drawing.Point(38, 507);
            this.buttonPanouAdmin.Name = "buttonPanouAdmin";
            this.buttonPanouAdmin.Size = new System.Drawing.Size(158, 57);
            this.buttonPanouAdmin.TabIndex = 18;
            this.buttonPanouAdmin.Text = "Concedii";
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
            this.buttonDetaliiAngajati.Location = new System.Drawing.Point(38, 427);
            this.buttonDetaliiAngajati.Margin = new System.Windows.Forms.Padding(0, 0, 38, 20);
            this.buttonDetaliiAngajati.Name = "buttonDetaliiAngajati";
            this.buttonDetaliiAngajati.Size = new System.Drawing.Size(158, 57);
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
            this.buttonCerereConcediu.Location = new System.Drawing.Point(38, 274);
            this.buttonCerereConcediu.Margin = new System.Windows.Forms.Padding(0, 0, 38, 20);
            this.buttonCerereConcediu.Name = "buttonCerereConcediu";
            this.buttonCerereConcediu.Size = new System.Drawing.Size(158, 57);
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
            this.buttonPaginaMea.Location = new System.Drawing.Point(38, 197);
            this.buttonPaginaMea.Margin = new System.Windows.Forms.Padding(0, 0, 38, 20);
            this.buttonPaginaMea.Name = "buttonPaginaMea";
            this.buttonPaginaMea.Size = new System.Drawing.Size(158, 57);
            this.buttonPaginaMea.TabIndex = 15;
            this.buttonPaginaMea.Text = "Pagina Mea";
            this.buttonPaginaMea.UseVisualStyleBackColor = false;
            this.buttonPaginaMea.Click += new System.EventHandler(this.buttonPaginaMea_Click);
            // 
            // panelContinut
            // 
            this.panelContinut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContinut.AutoScroll = true;
            this.panelContinut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.panelContinut.Controls.Add(this.tableLayoutPanel3);
            this.panelContinut.Controls.Add(this.tableLayoutPanel2);
            this.panelContinut.Controls.Add(this.labelCereriConcediu);
            this.panelContinut.Controls.Add(this.dgvTabelConcedii);
            this.panelContinut.Location = new System.Drawing.Point(233, 197);
            this.panelContinut.Margin = new System.Windows.Forms.Padding(0);
            this.panelContinut.Name = "panelContinut";
            this.panelContinut.Padding = new System.Windows.Forms.Padding(38, 61, 38, 41);
            this.panelContinut.Size = new System.Drawing.Size(769, 400);
            this.panelContinut.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.Controls.Add(this.labelPageNumber, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonPaginaAnterioara, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonPaginaUrmatoare, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(38, 323);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 41, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(694, 37);
            this.tableLayoutPanel3.TabIndex = 46;
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageNumber.AutoSize = true;
            this.labelPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageNumber.ForeColor = System.Drawing.Color.Peru;
            this.labelPageNumber.Location = new System.Drawing.Point(314, 4);
            this.labelPageNumber.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(65, 24);
            this.labelPageNumber.TabIndex = 46;
            this.labelPageNumber.Text = "1";
            this.labelPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPaginaAnterioara
            // 
            this.buttonPaginaAnterioara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaginaAnterioara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(111)))));
            this.buttonPaginaAnterioara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaginaAnterioara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPaginaAnterioara.Location = new System.Drawing.Point(278, 0);
            this.buttonPaginaAnterioara.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPaginaAnterioara.Name = "buttonPaginaAnterioara";
            this.buttonPaginaAnterioara.Size = new System.Drawing.Size(34, 32);
            this.buttonPaginaAnterioara.TabIndex = 43;
            this.buttonPaginaAnterioara.Text = "<";
            this.buttonPaginaAnterioara.UseVisualStyleBackColor = false;
            this.buttonPaginaAnterioara.Visible = false;
            this.buttonPaginaAnterioara.Click += new System.EventHandler(this.buttonPaginaAnterioara_Click);
            // 
            // buttonPaginaUrmatoare
            // 
            this.buttonPaginaUrmatoare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(111)))));
            this.buttonPaginaUrmatoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaginaUrmatoare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPaginaUrmatoare.Location = new System.Drawing.Point(381, 0);
            this.buttonPaginaUrmatoare.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPaginaUrmatoare.Name = "buttonPaginaUrmatoare";
            this.buttonPaginaUrmatoare.Size = new System.Drawing.Size(34, 32);
            this.buttonPaginaUrmatoare.TabIndex = 44;
            this.buttonPaginaUrmatoare.Text = ">";
            this.buttonPaginaUrmatoare.UseVisualStyleBackColor = false;
            this.buttonPaginaUrmatoare.Visible = false;
            this.buttonPaginaUrmatoare.Click += new System.EventHandler(this.buttonPaginaUrmatoare_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel2.Controls.Add(this.tbFiltrareNume, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAplicaFiltre, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbTipConcedii, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpDataFinal, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbStariConcedii, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lDataFinal, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lStareConcediu, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpDataInceput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lDataInceput, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lNume, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(38, 127);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 110);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // labelCereriConcediu
            // 
            this.labelCereriConcediu.AutoSize = true;
            this.labelCereriConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCereriConcediu.ForeColor = System.Drawing.Color.Peru;
            this.labelCereriConcediu.Location = new System.Drawing.Point(38, 61);
            this.labelCereriConcediu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 41);
            this.labelCereriConcediu.Name = "labelCereriConcediu";
            this.labelCereriConcediu.Size = new System.Drawing.Size(105, 26);
            this.labelCereriConcediu.TabIndex = 17;
            this.labelCereriConcediu.Text = "Concedii";
            // 
            // Tabel_Concedii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabel_Concedii";
            this.Text = "Tabel_Concedii";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tabel_Concedii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelConcedii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stareConcediuBindingSource)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatorLogat)).EndInit();
            this.panelContinut.ResumeLayout(false);
            this.panelContinut.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource breakingBreadDataSetBindingSource;
        private BreakingBreadDataSet breakingBreadDataSet;
        private System.Windows.Forms.DataGridView dgvTabelConcedii;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox cbStariConcedii;
        private System.Windows.Forms.BindingSource stareConcediuBindingSource;
        private BreakingBreadDataSetTableAdapters.StareConcediuTableAdapter stareConcediuTableAdapter;
        private System.Windows.Forms.Label lStareConcediu;
        private System.Windows.Forms.TextBox tbFiltrareNume;
        private System.Windows.Forms.Label lDataInceput;
        private System.Windows.Forms.DateTimePicker dtpDataInceput;
        private System.Windows.Forms.Label lDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.ComboBox cbTipConcedii;
        private System.Windows.Forms.Label lNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplicaFiltre;
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
        private System.Windows.Forms.Panel panelContinut;
        private System.Windows.Forms.Label labelCereriConcediu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelPageNumber;
        private System.Windows.Forms.Button buttonPaginaAnterioara;
        private System.Windows.Forms.Button buttonPaginaUrmatoare;
    }
}