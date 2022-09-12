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
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelConcedii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stareConcediuBindingSource)).BeginInit();
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
            this.dgvTabelConcedii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabelConcedii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelConcedii.Location = new System.Drawing.Point(-6, 87);
            this.dgvTabelConcedii.Name = "dgvTabelConcedii";
            this.dgvTabelConcedii.RowHeadersWidth = 51;
            this.dgvTabelConcedii.Size = new System.Drawing.Size(1047, 391);
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
            this.cbStariConcedii.FormattingEnabled = true;
            this.cbStariConcedii.Location = new System.Drawing.Point(654, 60);
            this.cbStariConcedii.Name = "cbStariConcedii";
            this.cbStariConcedii.Size = new System.Drawing.Size(121, 21);
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
            this.lStareConcediu.Location = new System.Drawing.Point(651, 44);
            this.lStareConcediu.Name = "lStareConcediu";
            this.lStareConcediu.Size = new System.Drawing.Size(80, 13);
            this.lStareConcediu.TabIndex = 7;
            this.lStareConcediu.Text = "Stare Concediu";
            // 
            // tbFiltrareNume
            // 
            this.tbFiltrareNume.Location = new System.Drawing.Point(13, 60);
            this.tbFiltrareNume.Name = "tbFiltrareNume";
            this.tbFiltrareNume.Size = new System.Drawing.Size(123, 20);
            this.tbFiltrareNume.TabIndex = 8;
            this.tbFiltrareNume.Leave += new System.EventHandler(this.tbFiltrareNume_Leave);
            // 
            // dtpDataInceput
            // 
            this.dtpDataInceput.Location = new System.Drawing.Point(155, 60);
            this.dtpDataInceput.Name = "dtpDataInceput";
            this.dtpDataInceput.Size = new System.Drawing.Size(172, 20);
            this.dtpDataInceput.TabIndex = 9;
            this.dtpDataInceput.ValueChanged += new System.EventHandler(this.dtpDataInceput_ValueChanged);
            // 
            // lDataInceput
            // 
            this.lDataInceput.AutoSize = true;
            this.lDataInceput.Location = new System.Drawing.Point(152, 44);
            this.lDataInceput.Name = "lDataInceput";
            this.lDataInceput.Size = new System.Drawing.Size(69, 13);
            this.lDataInceput.TabIndex = 10;
            this.lDataInceput.Text = "Data Inceput";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Location = new System.Drawing.Point(343, 60);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(172, 20);
            this.dtpDataFinal.TabIndex = 11;
            this.dtpDataFinal.ValueChanged += new System.EventHandler(this.dtpDataFinal_ValueChanged);
            // 
            // lDataFinal
            // 
            this.lDataFinal.AutoSize = true;
            this.lDataFinal.Location = new System.Drawing.Point(340, 44);
            this.lDataFinal.Name = "lDataFinal";
            this.lDataFinal.Size = new System.Drawing.Size(55, 13);
            this.lDataFinal.TabIndex = 12;
            this.lDataFinal.Text = "Data Final";
            // 
            // lNume
            // 
            this.lNume.AutoSize = true;
            this.lNume.Location = new System.Drawing.Point(12, 44);
            this.lNume.Name = "lNume";
            this.lNume.Size = new System.Drawing.Size(35, 13);
            this.lNume.TabIndex = 13;
            this.lNume.Text = "Nume";
            // 
            // cbTipConcedii
            // 
            this.cbTipConcedii.FormattingEnabled = true;
            this.cbTipConcedii.Location = new System.Drawing.Point(524, 60);
            this.cbTipConcedii.Name = "cbTipConcedii";
            this.cbTipConcedii.Size = new System.Drawing.Size(121, 21);
            this.cbTipConcedii.TabIndex = 14;
            this.cbTipConcedii.SelectionChangeCommitted += new System.EventHandler(this.cbTipConcedii_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tip Concediu";
            // 
            // btnAplicaFiltre
            // 
            this.btnAplicaFiltre.Location = new System.Drawing.Point(811, 57);
            this.btnAplicaFiltre.Name = "btnAplicaFiltre";
            this.btnAplicaFiltre.Size = new System.Drawing.Size(75, 23);
            this.btnAplicaFiltre.TabIndex = 16;
            this.btnAplicaFiltre.Text = "Aplica Filtre";
            this.btnAplicaFiltre.UseVisualStyleBackColor = true;
            this.btnAplicaFiltre.Click += new System.EventHandler(this.btnAplicaFiltre_Click);
            // 
            // Tabel_Concedii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 534);
            this.Controls.Add(this.btnAplicaFiltre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipConcedii);
            this.Controls.Add(this.lNume);
            this.Controls.Add(this.lDataFinal);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.lDataInceput);
            this.Controls.Add(this.dtpDataInceput);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelConcedii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stareConcediuBindingSource)).EndInit();
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
    }
}