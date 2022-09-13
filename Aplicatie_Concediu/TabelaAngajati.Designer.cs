namespace Aplicatie_Concediu
{
    partial class TabelaAngajati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaAngajati));
            this.dgvAngajati = new System.Windows.Forms.DataGridView();
            this.coloanaPoza = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPageNumber = new System.Windows.Forms.Label();
            this.buttonPaginaAnterioara = new System.Windows.Forms.Button();
            this.buttonPaginaUrmatoare = new System.Windows.Forms.Button();
            this.labelDetaliiAngajati = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngajati)).BeginInit();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatorLogat)).BeginInit();
            this.panelContinut.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAngajati
            // 
            this.dgvAngajati.AllowUserToAddRows = false;
            this.dgvAngajati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngajati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coloanaPoza});
            this.dgvAngajati.Location = new System.Drawing.Point(54, 185);
            this.dgvAngajati.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAngajati.Name = "dgvAngajati";
            this.dgvAngajati.RowHeadersWidth = 51;
            this.dgvAngajati.Size = new System.Drawing.Size(1081, 253);
            this.dgvAngajati.TabIndex = 0;
            // 
            // coloanaPoza
            // 
            this.coloanaPoza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coloanaPoza.DataPropertyName = "poza";
            this.coloanaPoza.HeaderText = "Poza";
            this.coloanaPoza.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.coloanaPoza.MinimumWidth = 50;
            this.coloanaPoza.Name = "coloanaPoza";
            // 
            // panelBackground
            // 
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
            this.panelBackground.Padding = new System.Windows.Forms.Padding(50);
            this.panelBackground.Size = new System.Drawing.Size(1556, 884);
            this.panelBackground.TabIndex = 39;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(50, 9);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(211, 228);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 38;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonIesire
            // 
            this.buttonIesire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIesire.ForeColor = System.Drawing.Color.Peru;
            this.buttonIesire.Location = new System.Drawing.Point(1461, 50);
            this.buttonIesire.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(45, 40);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.Controls.Add(this.labelSeparator, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNumeUtilizatorLogat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxUtilizatorLogat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDeconectare, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(938, 115);
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
            this.labelSeparator.Location = new System.Drawing.Point(301, 0);
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
            this.labelNumeUtilizatorLogat.Location = new System.Drawing.Point(72, 0);
            this.labelNumeUtilizatorLogat.Name = "labelNumeUtilizatorLogat";
            this.labelNumeUtilizatorLogat.Size = new System.Drawing.Size(223, 76);
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
            this.pictureBoxUtilizatorLogat.Size = new System.Drawing.Size(63, 72);
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
            this.labelDeconectare.Location = new System.Drawing.Point(333, 0);
            this.labelDeconectare.Name = "labelDeconectare";
            this.labelDeconectare.Size = new System.Drawing.Size(232, 76);
            this.labelDeconectare.TabIndex = 36;
            this.labelDeconectare.Text = "Deconectare";
            this.labelDeconectare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonIstoricConcedii
            // 
            this.buttonIstoricConcedii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonIstoricConcedii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIstoricConcedii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIstoricConcedii.ForeColor = System.Drawing.Color.Peru;
            this.buttonIstoricConcedii.Location = new System.Drawing.Point(50, 432);
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
            this.buttonPanouAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonPanouAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPanouAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPanouAdmin.ForeColor = System.Drawing.Color.Peru;
            this.buttonPanouAdmin.Location = new System.Drawing.Point(50, 620);
            this.buttonPanouAdmin.Margin = new System.Windows.Forms.Padding(0, 0, 50, 25);
            this.buttonPanouAdmin.Name = "buttonPanouAdmin";
            this.buttonPanouAdmin.Size = new System.Drawing.Size(211, 70);
            this.buttonPanouAdmin.TabIndex = 18;
            this.buttonPanouAdmin.Text = "Concedii";
            this.buttonPanouAdmin.UseVisualStyleBackColor = false;
            this.buttonPanouAdmin.Visible = false;
            this.buttonPanouAdmin.Click += new System.EventHandler(this.buttonPanouAdmin_Click);
            // 
            // buttonDetaliiAngajati
            // 
            this.buttonDetaliiAngajati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.buttonDetaliiAngajati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetaliiAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetaliiAngajati.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDetaliiAngajati.Location = new System.Drawing.Point(50, 525);
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
            this.buttonCerereConcediu.Location = new System.Drawing.Point(50, 337);
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
            this.buttonPaginaMea.Location = new System.Drawing.Point(50, 242);
            this.buttonPaginaMea.Margin = new System.Windows.Forms.Padding(0, 0, 50, 25);
            this.buttonPaginaMea.Name = "buttonPaginaMea";
            this.buttonPaginaMea.Size = new System.Drawing.Size(211, 70);
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
            this.panelContinut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.panelContinut.Controls.Add(this.tableLayoutPanel2);
            this.panelContinut.Controls.Add(this.labelDetaliiAngajati);
            this.panelContinut.Controls.Add(this.dgvAngajati);
            this.panelContinut.Location = new System.Drawing.Point(314, 242);
            this.panelContinut.Margin = new System.Windows.Forms.Padding(0);
            this.panelContinut.Name = "panelContinut";
            this.panelContinut.Padding = new System.Windows.Forms.Padding(50, 75, 50, 50);
            this.panelContinut.Size = new System.Drawing.Size(1189, 590);
            this.panelContinut.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Controls.Add(this.labelPageNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonPaginaAnterioara, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonPaginaUrmatoare, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(53, 492);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1083, 45);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageNumber.AutoSize = true;
            this.labelPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageNumber.ForeColor = System.Drawing.Color.Peru;
            this.labelPageNumber.Location = new System.Drawing.Point(490, 5);
            this.labelPageNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(102, 29);
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
            this.buttonPaginaAnterioara.Location = new System.Drawing.Point(442, 0);
            this.buttonPaginaAnterioara.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPaginaAnterioara.Name = "buttonPaginaAnterioara";
            this.buttonPaginaAnterioara.Size = new System.Drawing.Size(45, 39);
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
            this.buttonPaginaUrmatoare.Location = new System.Drawing.Point(595, 0);
            this.buttonPaginaUrmatoare.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPaginaUrmatoare.Name = "buttonPaginaUrmatoare";
            this.buttonPaginaUrmatoare.Size = new System.Drawing.Size(45, 39);
            this.buttonPaginaUrmatoare.TabIndex = 44;
            this.buttonPaginaUrmatoare.Text = ">";
            this.buttonPaginaUrmatoare.UseVisualStyleBackColor = false;
            this.buttonPaginaUrmatoare.Visible = false;
            this.buttonPaginaUrmatoare.Click += new System.EventHandler(this.buttonPaginaUrmatoare_Click);
            // 
            // labelDetaliiAngajati
            // 
            this.labelDetaliiAngajati.AutoSize = true;
            this.labelDetaliiAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetaliiAngajati.ForeColor = System.Drawing.Color.Peru;
            this.labelDetaliiAngajati.Location = new System.Drawing.Point(50, 75);
            this.labelDetaliiAngajati.Margin = new System.Windows.Forms.Padding(0, 0, 0, 75);
            this.labelDetaliiAngajati.Name = "labelDetaliiAngajati";
            this.labelDetaliiAngajati.Size = new System.Drawing.Size(211, 31);
            this.labelDetaliiAngajati.TabIndex = 12;
            this.labelDetaliiAngajati.Text = "Detalii Angajati";
            // 
            // TabelaAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabelaAngajati";
            this.Text = "6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TabelaAngajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngajati)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatorLogat)).EndInit();
            this.panelContinut.ResumeLayout(false);
            this.panelContinut.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAngajati;
        private System.Windows.Forms.Panel panelBackground;
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
        private System.Windows.Forms.Label labelDetaliiAngajati;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonPaginaAnterioara;
        private System.Windows.Forms.Button buttonPaginaUrmatoare;
        private System.Windows.Forms.Label labelPageNumber;
        private System.Windows.Forms.DataGridViewImageColumn coloanaPoza;
    }
}