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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.breakingBreadDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breakingBreadDataSet = new Aplicatie_Concediu.BreakingBreadDataSet();
            this.var_nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var_prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip_concediu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concediu_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_concediu_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inlocuitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var_stare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.var_nume,
            this.var_prenume,
            this.Manager,
            this.tip_concediu,
            this.Concediu_i,
            this.data_concediu_f,
            this.inlocuitor,
            this.var_stare});
            this.dataGridView1.DataSource = this.breakingBreadDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 269);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // var_nume
            // 
            this.var_nume.HeaderText = "Nume";
            this.var_nume.MinimumWidth = 6;
            this.var_nume.Name = "var_nume";
            this.var_nume.ReadOnly = true;
            this.var_nume.Width = 170;
            // 
            // var_prenume
            // 
            this.var_prenume.HeaderText = "Prenume";
            this.var_prenume.MinimumWidth = 6;
            this.var_prenume.Name = "var_prenume";
            this.var_prenume.Width = 170;
            // 
            // Manager
            // 
            this.Manager.HeaderText = "Manager";
            this.Manager.MinimumWidth = 6;
            this.Manager.Name = "Manager";
            this.Manager.Width = 125;
            // 
            // tip_concediu
            // 
            this.tip_concediu.HeaderText = "Tip Concediu";
            this.tip_concediu.MinimumWidth = 6;
            this.tip_concediu.Name = "tip_concediu";
            this.tip_concediu.Width = 125;
            // 
            // Concediu_i
            // 
            this.Concediu_i.HeaderText = "Data Incepere Concediu";
            this.Concediu_i.MinimumWidth = 6;
            this.Concediu_i.Name = "Concediu_i";
            this.Concediu_i.Width = 125;
            // 
            // data_concediu_f
            // 
            this.data_concediu_f.HeaderText = "Data Final Concediu";
            this.data_concediu_f.MinimumWidth = 6;
            this.data_concediu_f.Name = "data_concediu_f";
            this.data_concediu_f.Width = 170;
            // 
            // inlocuitor
            // 
            this.inlocuitor.HeaderText = "Inlocuitor";
            this.inlocuitor.MinimumWidth = 6;
            this.inlocuitor.Name = "inlocuitor";
            this.inlocuitor.Width = 125;
            // 
            // var_stare
            // 
            this.var_stare.HeaderText = "Stare";
            this.var_stare.MinimumWidth = 6;
            this.var_stare.Name = "var_stare";
            this.var_stare.Width = 170;
            // 
            // Tabel_Concedii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 534);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tabel_Concedii";
            this.Text = "Tabel_Concedii";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tabel_Concedii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource breakingBreadDataSetBindingSource;
        private BreakingBreadDataSet breakingBreadDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn var_nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn var_prenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip_concediu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concediu_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_concediu_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn inlocuitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn var_stare;
    }
}