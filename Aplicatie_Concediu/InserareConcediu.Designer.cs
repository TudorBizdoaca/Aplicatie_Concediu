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
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.cbTipConcediu.Location = new System.Drawing.Point(162, 3);
            this.cbTipConcediu.Name = "cbTipConcediu";
            this.cbTipConcediu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTipConcediu.Size = new System.Drawing.Size(233, 28);
            this.cbTipConcediu.TabIndex = 0;
            this.cbTipConcediu.Text = "TipConcediu:";
            // 
            // dtpInceputConcediu
            // 
            this.dtpInceputConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInceputConcediu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInceputConcediu.Location = new System.Drawing.Point(162, 84);
            this.dtpInceputConcediu.Name = "dtpInceputConcediu";
            this.dtpInceputConcediu.Size = new System.Drawing.Size(233, 20);
            this.dtpInceputConcediu.TabIndex = 2;
            this.dtpInceputConcediu.ValueChanged += new System.EventHandler(this.dtpInceputConcediu_ValueChanged);
            // 
            // dtpFinalConcediu
            // 
            this.dtpFinalConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFinalConcediu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinalConcediu.Location = new System.Drawing.Point(560, 84);
            this.dtpFinalConcediu.Name = "dtpFinalConcediu";
            this.dtpFinalConcediu.Size = new System.Drawing.Size(234, 20);
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
            this.cbInlocuitor.Location = new System.Drawing.Point(560, 3);
            this.cbInlocuitor.Name = "cbInlocuitor";
            this.cbInlocuitor.Size = new System.Drawing.Size(234, 28);
            this.cbInlocuitor.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(627, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 47);
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
            this.rtfComentarii.Location = new System.Drawing.Point(162, 165);
            this.rtfComentarii.MaxLength = 500;
            this.rtfComentarii.Name = "rtfComentarii";
            this.rtfComentarii.Size = new System.Drawing.Size(632, 144);
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
            this.lblCharCount.Location = new System.Drawing.Point(560, 312);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(234, 55);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 97);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 367);
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
            this.labelComentarii.Location = new System.Drawing.Point(3, 162);
            this.labelComentarii.Name = "labelComentarii";
            this.labelComentarii.Size = new System.Drawing.Size(153, 150);
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
            this.labelFinalConcediu.Location = new System.Drawing.Point(401, 81);
            this.labelFinalConcediu.Name = "labelFinalConcediu";
            this.labelFinalConcediu.Size = new System.Drawing.Size(153, 81);
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
            this.labelStartConcediu.Location = new System.Drawing.Point(3, 81);
            this.labelStartConcediu.Name = "labelStartConcediu";
            this.labelStartConcediu.Size = new System.Drawing.Size(153, 81);
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
            this.labelInlocuitor.Location = new System.Drawing.Point(401, 0);
            this.labelInlocuitor.Name = "labelInlocuitor";
            this.labelInlocuitor.Size = new System.Drawing.Size(153, 81);
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
            this.labelTipConcediu.Location = new System.Drawing.Point(3, 0);
            this.labelTipConcediu.Name = "labelTipConcediu";
            this.labelTipConcediu.Size = new System.Drawing.Size(153, 81);
            this.labelTipConcediu.TabIndex = 13;
            this.labelTipConcediu.Text = "Tip Concediu:";
            this.labelTipConcediu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCerereConcediu
            // 
            this.labelCerereConcediu.AutoSize = true;
            this.labelCerereConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCerereConcediu.ForeColor = System.Drawing.Color.Peru;
            this.labelCerereConcediu.Location = new System.Drawing.Point(17, 33);
            this.labelCerereConcediu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCerereConcediu.Name = "labelCerereConcediu";
            this.labelCerereConcediu.Size = new System.Drawing.Size(170, 24);
            this.labelCerereConcediu.TabIndex = 13;
            this.labelCerereConcediu.Text = "Cerere Concediu";
            // 
            // InserareConcediu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(842, 575);
            this.Controls.Add(this.labelCerereConcediu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "InserareConcediu";
            this.Text = "InserareConcediu";
            this.Load += new System.EventHandler(this.InserareConcediu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}