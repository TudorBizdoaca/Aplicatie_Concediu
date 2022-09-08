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
            this.cbStariConcedii.Location = new System.Drawing.Point(681, 60);
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
            this.lStareConcediu.Location = new System.Drawing.Point(678, 44);
            this.lStareConcediu.Name = "lStareConcediu";
            this.lStareConcediu.Size = new System.Drawing.Size(80, 13);
            this.lStareConcediu.TabIndex = 7;
            this.lStareConcediu.Text = "Stare Concediu";
            // 
            // Tabel_Concedii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 534);
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
    }
}