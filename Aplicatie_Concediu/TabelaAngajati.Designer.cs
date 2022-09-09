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
            this.labelDetaliiAngajati = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngajati)).BeginInit();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatorLogat)).BeginInit();
            this.panelContinut.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAngajati
            // 
            this.dgvAngajati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngajati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coloanaPoza});
            this.dgvAngajati.Location = new System.Drawing.Point(41, 123);
            this.dgvAngajati.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAngajati.Name = "dgvAngajati";
            this.dgvAngajati.RowHeadersWidth = 51;
            this.dgvAngajati.Size = new System.Drawing.Size(1138, 470);
            this.dgvAngajati.TabIndex = 0;
            // 
            // coloanaPoza
            // 
            this.coloanaPoza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coloanaPoza.DataPropertyName = "poza";
            this.coloanaPoza.HeaderText = "poza:";
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
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1556, 884);
            this.panelBackground.TabIndex = 39;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(41, 27);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(211, 185);
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
            this.buttonIesire.Location = new System.Drawing.Point(1487, 27);
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
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.22946F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.77054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel1.Controls.Add(this.labelSeparator, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNumeUtilizatorLogat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxUtilizatorLogat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDeconectare, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(964, 84);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
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
            this.labelSeparator.Location = new System.Drawing.Point(309, 0);
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
            this.labelNumeUtilizatorLogat.Location = new System.Drawing.Point(74, 0);
            this.labelNumeUtilizatorLogat.Name = "labelNumeUtilizatorLogat";
            this.labelNumeUtilizatorLogat.Size = new System.Drawing.Size(229, 76);
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
            this.pictureBoxUtilizatorLogat.Size = new System.Drawing.Size(65, 72);
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
            this.labelDeconectare.Location = new System.Drawing.Point(341, 0);
            this.labelDeconectare.Name = "labelDeconectare";
            this.labelDeconectare.Size = new System.Drawing.Size(224, 76);
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
            this.buttonIstoricConcedii.Location = new System.Drawing.Point(41, 436);
            this.buttonIstoricConcedii.Margin = new System.Windows.Forms.Padding(4);
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
            this.buttonPanouAdmin.Location = new System.Drawing.Point(41, 636);
            this.buttonPanouAdmin.Margin = new System.Windows.Forms.Padding(4);
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
            this.buttonDetaliiAngajati.Location = new System.Drawing.Point(41, 539);
            this.buttonDetaliiAngajati.Margin = new System.Windows.Forms.Padding(4);
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
            this.buttonCerereConcediu.Location = new System.Drawing.Point(41, 335);
            this.buttonCerereConcediu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCerereConcediu.Name = "buttonCerereConcediu";
            this.buttonCerereConcediu.Size = new System.Drawing.Size(211, 70);
            this.buttonCerereConcediu.TabIndex = 16;
            this.buttonCerereConcediu.Text = "Cerere Concediu";
            this.buttonCerereConcediu.UseVisualStyleBackColor = false;
            this.buttonCerereConcediu.Click += new System.EventHandler(this.buttonCerereConcediu_Click);
            // 
            // buttonPaginaMea
            // 
            this.buttonPaginaMea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.buttonPaginaMea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaginaMea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaginaMea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPaginaMea.Location = new System.Drawing.Point(41, 241);
            this.buttonPaginaMea.Margin = new System.Windows.Forms.Padding(4);
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
            this.panelContinut.Controls.Add(this.labelDetaliiAngajati);
            this.panelContinut.Controls.Add(this.dgvAngajati);
            this.panelContinut.Location = new System.Drawing.Point(304, 190);
            this.panelContinut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContinut.Name = "panelContinut";
            this.panelContinut.Size = new System.Drawing.Size(1225, 670);
            this.panelContinut.TabIndex = 9;
            // 
            // labelDetaliiAngajati
            // 
            this.labelDetaliiAngajati.AutoSize = true;
            this.labelDetaliiAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetaliiAngajati.ForeColor = System.Drawing.Color.Peru;
            this.labelDetaliiAngajati.Location = new System.Drawing.Point(36, 51);
            this.labelDetaliiAngajati.Name = "labelDetaliiAngajati";
            this.labelDetaliiAngajati.Size = new System.Drawing.Size(189, 29);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatorLogat)).EndInit();
            this.panelContinut.ResumeLayout(false);
            this.panelContinut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAngajati;
        private System.Windows.Forms.DataGridViewImageColumn coloanaPoza;
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
        private System.Windows.Forms.Label labelDetaliiAngajati;
    }
}