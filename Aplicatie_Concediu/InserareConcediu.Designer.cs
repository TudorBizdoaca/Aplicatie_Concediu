namespace Aplicatie_Concediu
{
    partial class InserareConcediu
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
            this.breakingBreadDataSet = new Aplicatie_Concediu.BreakingBreadDataSet();
            this.tipConcediuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipConcediuTableAdapter = new Aplicatie_Concediu.BreakingBreadDataSetTableAdapters.TipConcediuTableAdapter();
            this.tipConcediuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbTipConcediu = new System.Windows.Forms.ComboBox();
            this.dtpInceputConcediu = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalConcediu = new System.Windows.Forms.DateTimePicker();
            this.cbInlocuitor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtfComentarii = new System.Windows.Forms.RichTextBox();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelComentarii = new System.Windows.Forms.Label();
            this.labelFinalConcediu = new System.Windows.Forms.Label();
            this.labelStartConcediu = new System.Windows.Forms.Label();
            this.labelInlocuitor = new System.Windows.Forms.Label();
            this.labelTipConcediu = new System.Windows.Forms.Label();
            this.labelCerereConcediu = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // breakingBreadDataSet
            // 
            this.breakingBreadDataSet.DataSetName = "BreakingBreadDataSet";
            this.breakingBreadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipConcediuBindingSource
            // 
            this.tipConcediuBindingSource.DataMember = "TipConcediu";
            this.tipConcediuBindingSource.DataSource = this.breakingBreadDataSet;
            // 
            // tipConcediuTableAdapter
            // 
            this.tipConcediuTableAdapter.ClearBeforeFill = true;
            // 
            // tipConcediuBindingSource1
            // 
            this.tipConcediuBindingSource1.DataMember = "TipConcediu";
            this.tipConcediuBindingSource1.DataSource = this.breakingBreadDataSet;
            // 
            // cbTipConcediu
            // 
            this.cbTipConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipConcediu.FormattingEnabled = true;
            this.cbTipConcediu.Location = new System.Drawing.Point(212, 4);
            this.cbTipConcediu.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipConcediu.Name = "cbTipConcediu";
            this.cbTipConcediu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTipConcediu.Size = new System.Drawing.Size(304, 33);
            this.cbTipConcediu.TabIndex = 0;
            this.cbTipConcediu.Text = "TipConcediu:";
            // 
            // dtpInceputConcediu
            // 
            this.dtpInceputConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInceputConcediu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInceputConcediu.Location = new System.Drawing.Point(212, 104);
            this.dtpInceputConcediu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInceputConcediu.Name = "dtpInceputConcediu";
            this.dtpInceputConcediu.Size = new System.Drawing.Size(304, 22);
            this.dtpInceputConcediu.TabIndex = 2;
            this.dtpInceputConcediu.ValueChanged += new System.EventHandler(this.dtpInceputConcediu_ValueChanged);
            // 
            // dtpFinalConcediu
            // 
            this.dtpFinalConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFinalConcediu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinalConcediu.Location = new System.Drawing.Point(732, 104);
            this.dtpFinalConcediu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinalConcediu.Name = "dtpFinalConcediu";
            this.dtpFinalConcediu.Size = new System.Drawing.Size(306, 22);
            this.dtpFinalConcediu.TabIndex = 3;
            this.dtpFinalConcediu.ValueChanged += new System.EventHandler(this.dtpFinalConcediu_ValueChanged);
            // 
            // cbInlocuitor
            // 
            this.cbInlocuitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInlocuitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInlocuitor.FormattingEnabled = true;
            this.cbInlocuitor.Location = new System.Drawing.Point(732, 4);
            this.cbInlocuitor.Margin = new System.Windows.Forms.Padding(4);
            this.cbInlocuitor.Name = "cbInlocuitor";
            this.cbInlocuitor.Size = new System.Drawing.Size(306, 33);
            this.cbInlocuitor.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(815, 606);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "InsereazaConcediu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtfComentarii
            // 
            this.rtfComentarii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.rtfComentarii, 3);
            this.rtfComentarii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfComentarii.Location = new System.Drawing.Point(212, 204);
            this.rtfComentarii.Margin = new System.Windows.Forms.Padding(4);
            this.rtfComentarii.MaxLength = 500;
            this.rtfComentarii.Name = "rtfComentarii";
            this.rtfComentarii.Size = new System.Drawing.Size(826, 176);
            this.rtfComentarii.TabIndex = 9;
            this.rtfComentarii.Text = "";
            this.rtfComentarii.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtfComentarii_KeyPress);
            // 
            // lblCharCount
            // 
            this.lblCharCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.lblCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount.ForeColor = System.Drawing.Color.Peru;
            this.lblCharCount.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCharCount.Location = new System.Drawing.Point(732, 384);
            this.lblCharCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(306, 68);
            this.lblCharCount.TabIndex = 11;
            this.lblCharCount.Text = "Caractere ramase: 500";
            this.lblCharCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.labelComentarii, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFinalConcediu, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelStartConcediu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelInlocuitor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTipConcediu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbTipConcediu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCharCount, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbInlocuitor, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtfComentarii, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpFinalConcediu, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpInceputConcediu, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 119);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 452);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // labelComentarii
            // 
            this.labelComentarii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelComentarii.AutoSize = true;
            this.labelComentarii.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentarii.ForeColor = System.Drawing.Color.Peru;
            this.labelComentarii.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelComentarii.Location = new System.Drawing.Point(4, 200);
            this.labelComentarii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComentarii.Name = "labelComentarii";
            this.labelComentarii.Size = new System.Drawing.Size(200, 184);
            this.labelComentarii.TabIndex = 17;
            this.labelComentarii.Text = "Comentarii:";
            this.labelComentarii.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFinalConcediu
            // 
            this.labelFinalConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFinalConcediu.AutoSize = true;
            this.labelFinalConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalConcediu.ForeColor = System.Drawing.Color.Peru;
            this.labelFinalConcediu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelFinalConcediu.Location = new System.Drawing.Point(524, 100);
            this.labelFinalConcediu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFinalConcediu.Name = "labelFinalConcediu";
            this.labelFinalConcediu.Size = new System.Drawing.Size(200, 100);
            this.labelFinalConcediu.TabIndex = 16;
            this.labelFinalConcediu.Text = "Final Concediu:";
            this.labelFinalConcediu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStartConcediu
            // 
            this.labelStartConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartConcediu.AutoSize = true;
            this.labelStartConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartConcediu.ForeColor = System.Drawing.Color.Peru;
            this.labelStartConcediu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelStartConcediu.Location = new System.Drawing.Point(4, 100);
            this.labelStartConcediu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartConcediu.Name = "labelStartConcediu";
            this.labelStartConcediu.Size = new System.Drawing.Size(200, 100);
            this.labelStartConcediu.TabIndex = 15;
            this.labelStartConcediu.Text = "Start Concediu:";
            this.labelStartConcediu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInlocuitor
            // 
            this.labelInlocuitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInlocuitor.AutoSize = true;
            this.labelInlocuitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInlocuitor.ForeColor = System.Drawing.Color.Peru;
            this.labelInlocuitor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelInlocuitor.Location = new System.Drawing.Point(524, 0);
            this.labelInlocuitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInlocuitor.Name = "labelInlocuitor";
            this.labelInlocuitor.Size = new System.Drawing.Size(200, 100);
            this.labelInlocuitor.TabIndex = 14;
            this.labelInlocuitor.Text = "Inlocuitor:";
            this.labelInlocuitor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTipConcediu
            // 
            this.labelTipConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTipConcediu.AutoSize = true;
            this.labelTipConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipConcediu.ForeColor = System.Drawing.Color.Peru;
            this.labelTipConcediu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTipConcediu.Location = new System.Drawing.Point(4, 0);
            this.labelTipConcediu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipConcediu.Name = "labelTipConcediu";
            this.labelTipConcediu.Size = new System.Drawing.Size(200, 100);
            this.labelTipConcediu.TabIndex = 13;
            this.labelTipConcediu.Text = "Tip Concediu:";
            this.labelTipConcediu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCerereConcediu
            // 
            this.labelCerereConcediu.AutoSize = true;
            this.labelCerereConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCerereConcediu.ForeColor = System.Drawing.Color.Peru;
            this.labelCerereConcediu.Location = new System.Drawing.Point(23, 41);
            this.labelCerereConcediu.Name = "labelCerereConcediu";
            this.labelCerereConcediu.Size = new System.Drawing.Size(212, 29);
            this.labelCerereConcediu.TabIndex = 13;
            this.labelCerereConcediu.Text = "Cerere Concediu";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1030, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 36);
            this.button2.TabIndex = 38;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.labelCerereConcediu);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 684);
            this.panel1.TabIndex = 39;
            // 
            // InserareConcediu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1123, 708);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InserareConcediu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InserareConcediu";
            this.Load += new System.EventHandler(this.InserareConcediu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BreakingBreadDataSet breakingBreadDataSet;
        private System.Windows.Forms.BindingSource tipConcediuBindingSource;
        private BreakingBreadDataSetTableAdapters.TipConcediuTableAdapter tipConcediuTableAdapter;
        private System.Windows.Forms.BindingSource tipConcediuBindingSource1;
        private System.Windows.Forms.ComboBox cbTipConcediu;
        private System.Windows.Forms.DateTimePicker dtpInceputConcediu;
        private System.Windows.Forms.DateTimePicker dtpFinalConcediu;
        private System.Windows.Forms.ComboBox cbInlocuitor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtfComentarii;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCerereConcediu;
        private System.Windows.Forms.Label labelStartConcediu;
        private System.Windows.Forms.Label labelInlocuitor;
        private System.Windows.Forms.Label labelTipConcediu;
        private System.Windows.Forms.Label labelComentarii;
        private System.Windows.Forms.Label labelFinalConcediu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}