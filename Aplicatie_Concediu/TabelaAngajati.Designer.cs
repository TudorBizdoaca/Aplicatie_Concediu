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
            this.dgvAngajati = new System.Windows.Forms.DataGridView();
            this.coloanaPoza = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAngajati
            // 
            this.dgvAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAngajati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coloanaPoza});
            this.dgvAngajati.Location = new System.Drawing.Point(12, 12);
            this.dgvAngajati.Name = "dgvAngajati";
            this.dgvAngajati.Size = new System.Drawing.Size(648, 362);
            this.dgvAngajati.TabIndex = 0;
            // 
            // coloanaPoza
            // 
            this.coloanaPoza.HeaderText = "poza:";
            this.coloanaPoza.Name = "coloanaPoza";
            // 
            // TabelaAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAngajati);
            this.Name = "TabelaAngajati";
            this.Text = "Angajati";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAngajati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAngajati;
        private System.Windows.Forms.DataGridViewImageColumn coloanaPoza;
    }
}