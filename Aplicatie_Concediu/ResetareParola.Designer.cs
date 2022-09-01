namespace Aplicatie_Concediu
{
    partial class ResetareParola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetareParola));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lEmailInreg = new System.Windows.Forms.Label();
            this.btnTrimiteCodVerificare = new System.Windows.Forms.Button();
            this.tbCodVerificare = new System.Windows.Forms.TextBox();
            this.lCodVerificare = new System.Windows.Forms.Label();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.tbConfirmaParola = new System.Windows.Forms.TextBox();
            this.btnResetareParola = new System.Windows.Forms.Button();
            this.lParolaInreg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(74, 68);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(235, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // lEmailInreg
            // 
            this.lEmailInreg.AutoSize = true;
            this.lEmailInreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmailInreg.Location = new System.Drawing.Point(71, 50);
            this.lEmailInreg.Name = "lEmailInreg";
            this.lEmailInreg.Size = new System.Drawing.Size(39, 15);
            this.lEmailInreg.TabIndex = 13;
            this.lEmailInreg.Text = "Email";
            // 
            // btnTrimiteCodVerificare
            // 
            this.btnTrimiteCodVerificare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.btnTrimiteCodVerificare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrimiteCodVerificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimiteCodVerificare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrimiteCodVerificare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrimiteCodVerificare.Location = new System.Drawing.Point(327, 68);
            this.btnTrimiteCodVerificare.Name = "btnTrimiteCodVerificare";
            this.btnTrimiteCodVerificare.Size = new System.Drawing.Size(130, 23);
            this.btnTrimiteCodVerificare.TabIndex = 36;
            this.btnTrimiteCodVerificare.Text = "Trimite cod verificare";
            this.btnTrimiteCodVerificare.UseVisualStyleBackColor = false;
            this.btnTrimiteCodVerificare.Click += new System.EventHandler(this.btnTrimiteCodVerificare_Click);
            // 
            // tbCodVerificare
            // 
            this.tbCodVerificare.Location = new System.Drawing.Point(474, 68);
            this.tbCodVerificare.Name = "tbCodVerificare";
            this.tbCodVerificare.Size = new System.Drawing.Size(235, 20);
            this.tbCodVerificare.TabIndex = 37;
            this.tbCodVerificare.TextChanged += new System.EventHandler(this.tbCodVerificare_TextChanged);
            // 
            // lCodVerificare
            // 
            this.lCodVerificare.AutoSize = true;
            this.lCodVerificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCodVerificare.Location = new System.Drawing.Point(471, 50);
            this.lCodVerificare.Name = "lCodVerificare";
            this.lCodVerificare.Size = new System.Drawing.Size(83, 15);
            this.lCodVerificare.TabIndex = 38;
            this.lCodVerificare.Text = "Cod Verificare";
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(265, 189);
            this.tbParola.Name = "tbParola";
            this.tbParola.PasswordChar = '*';
            this.tbParola.Size = new System.Drawing.Size(235, 20);
            this.tbParola.TabIndex = 39;
            // 
            // tbConfirmaParola
            // 
            this.tbConfirmaParola.Location = new System.Drawing.Point(265, 281);
            this.tbConfirmaParola.Name = "tbConfirmaParola";
            this.tbConfirmaParola.PasswordChar = '*';
            this.tbConfirmaParola.Size = new System.Drawing.Size(235, 20);
            this.tbConfirmaParola.TabIndex = 40;
            // 
            // btnResetareParola
            // 
            this.btnResetareParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.btnResetareParola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetareParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetareParola.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResetareParola.Image = ((System.Drawing.Image)(resources.GetObject("btnResetareParola.Image")));
            this.btnResetareParola.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetareParola.Location = new System.Drawing.Point(299, 361);
            this.btnResetareParola.Name = "btnResetareParola";
            this.btnResetareParola.Size = new System.Drawing.Size(183, 42);
            this.btnResetareParola.TabIndex = 41;
            this.btnResetareParola.Text = "Resetare";
            this.btnResetareParola.UseVisualStyleBackColor = false;
            this.btnResetareParola.Click += new System.EventHandler(this.btnResetareParola_Click);
            // 
            // lParolaInreg
            // 
            this.lParolaInreg.AutoSize = true;
            this.lParolaInreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lParolaInreg.Location = new System.Drawing.Point(262, 171);
            this.lParolaInreg.Name = "lParolaInreg";
            this.lParolaInreg.Size = new System.Drawing.Size(43, 15);
            this.lParolaInreg.TabIndex = 42;
            this.lParolaInreg.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Confirma Parola ";
            // 
            // ResetareParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lParolaInreg);
            this.Controls.Add(this.btnResetareParola);
            this.Controls.Add(this.tbConfirmaParola);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.lCodVerificare);
            this.Controls.Add(this.tbCodVerificare);
            this.Controls.Add(this.btnTrimiteCodVerificare);
            this.Controls.Add(this.lEmailInreg);
            this.Controls.Add(this.tbEmail);
            this.Name = "ResetareParola";
            this.Text = "ResetareParola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lEmailInreg;
        private System.Windows.Forms.Button btnTrimiteCodVerificare;
        private System.Windows.Forms.TextBox tbCodVerificare;
        private System.Windows.Forms.Label lCodVerificare;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.TextBox tbConfirmaParola;
        private System.Windows.Forms.Button btnResetareParola;
        private System.Windows.Forms.Label lParolaInreg;
        private System.Windows.Forms.Label label1;
    }
}