namespace Aplicatie_Concediu
{
    partial class MotivRespingere
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
            this.Motiv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Salveaza = new System.Windows.Forms.Button();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.Anuleaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Motiv
            // 
            this.Motiv.Location = new System.Drawing.Point(148, 87);
            this.Motiv.Multiline = true;
            this.Motiv.Name = "Motiv";
            this.Motiv.Size = new System.Drawing.Size(307, 128);
            this.Motiv.TabIndex = 1;
            this.Motiv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Motiv_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motivul Respingerii";
            // 
            // Salveaza
            // 
            this.Salveaza.Location = new System.Drawing.Point(148, 276);
            this.Salveaza.Name = "Salveaza";
            this.Salveaza.Size = new System.Drawing.Size(151, 30);
            this.Salveaza.TabIndex = 4;
            this.Salveaza.Text = "Salveaza";
            this.Salveaza.UseVisualStyleBackColor = true;
            this.Salveaza.Click += new System.EventHandler(this.Salveaza_Click);
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCharCount.Location = new System.Drawing.Point(335, 230);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(212, 25);
            this.lblCharCount.TabIndex = 6;
            this.lblCharCount.Text = "Caractere ramase: 500";
            // 
            // Anuleaza
            // 
            this.Anuleaza.Location = new System.Drawing.Point(340, 276);
            this.Anuleaza.Name = "Anuleaza";
            this.Anuleaza.Size = new System.Drawing.Size(151, 30);
            this.Anuleaza.TabIndex = 7;
            this.Anuleaza.Text = "Anuleaza";
            this.Anuleaza.UseVisualStyleBackColor = true;
            this.Anuleaza.Click += new System.EventHandler(this.Anuleaza_Click);
            // 
            // MotivRespingere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 345);
            this.Controls.Add(this.Anuleaza);
            this.Controls.Add(this.lblCharCount);
            this.Controls.Add(this.Salveaza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Motiv);
            this.Name = "MotivRespingere";
            this.Text = "MotivRespingere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Motiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Salveaza;
        private System.Windows.Forms.Button Anuleaza;
        public System.Windows.Forms.Label lblCharCount;
    }
}