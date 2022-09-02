namespace Aplicatie_Concediu
{
    partial class IstoricConcedii
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvIstoricConcedii = new System.Windows.Forms.DataGridView();
            this.labelIstoricConcedii = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricConcedii)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIstoricConcedii
            // 
            this.dgvIstoricConcedii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIstoricConcedii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIstoricConcedii.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIstoricConcedii.Location = new System.Drawing.Point(31, 103);
            this.dgvIstoricConcedii.Margin = new System.Windows.Forms.Padding(4);
            this.dgvIstoricConcedii.Name = "dgvIstoricConcedii";
            this.dgvIstoricConcedii.RowHeadersWidth = 51;
            this.dgvIstoricConcedii.Size = new System.Drawing.Size(1060, 488);
            this.dgvIstoricConcedii.TabIndex = 0;
            // 
            // labelIstoricConcedii
            // 
            this.labelIstoricConcedii.AutoSize = true;
            this.labelIstoricConcedii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.labelIstoricConcedii.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIstoricConcedii.ForeColor = System.Drawing.Color.Peru;
            this.labelIstoricConcedii.Location = new System.Drawing.Point(26, 42);
            this.labelIstoricConcedii.Name = "labelIstoricConcedii";
            this.labelIstoricConcedii.Size = new System.Drawing.Size(195, 29);
            this.labelIstoricConcedii.TabIndex = 43;
            this.labelIstoricConcedii.Text = "Istoric Concedii";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dgvIstoricConcedii);
            this.panel1.Controls.Add(this.labelIstoricConcedii);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 628);
            this.panel1.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1051, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 36);
            this.button2.TabIndex = 44;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IstoricConcedii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1149, 652);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IstoricConcedii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IstoricConcedii";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstoricConcedii)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIstoricConcedii;
        private System.Windows.Forms.Label labelIstoricConcedii;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}