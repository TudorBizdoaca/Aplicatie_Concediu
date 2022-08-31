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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbInlocuitor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource1)).BeginInit();
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
            this.cbTipConcediu.FormattingEnabled = true;
            this.cbTipConcediu.Location = new System.Drawing.Point(12, 73);
            this.cbTipConcediu.Name = "cbTipConcediu";
            this.cbTipConcediu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTipConcediu.Size = new System.Drawing.Size(121, 21);
            this.cbTipConcediu.TabIndex = 0;
            this.cbTipConcediu.Text = "TipConcediu:";
            // 
            // dtpInceputConcediu
            // 
            this.dtpInceputConcediu.Location = new System.Drawing.Point(164, 74);
            this.dtpInceputConcediu.Name = "dtpInceputConcediu";
            this.dtpInceputConcediu.Size = new System.Drawing.Size(200, 20);
            this.dtpInceputConcediu.TabIndex = 2;
            this.dtpInceputConcediu.ValueChanged += new System.EventHandler(this.dtpInceputConcediu_ValueChanged);
            // 
            // dtpFinalConcediu
            // 
            this.dtpFinalConcediu.Location = new System.Drawing.Point(405, 74);
            this.dtpFinalConcediu.Name = "dtpFinalConcediu";
            this.dtpFinalConcediu.Size = new System.Drawing.Size(200, 20);
            this.dtpFinalConcediu.TabIndex = 3;
            this.dtpFinalConcediu.ValueChanged += new System.EventHandler(this.dtpFinalConcediu_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start concediu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start concediu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inlocuitor:";
            // 
            // cbInlocuitor
            // 
            this.cbInlocuitor.FormattingEnabled = true;
            this.cbInlocuitor.Location = new System.Drawing.Point(627, 77);
            this.cbInlocuitor.Name = "cbInlocuitor";
            this.cbInlocuitor.Size = new System.Drawing.Size(121, 21);
            this.cbInlocuitor.TabIndex = 7;
            // 
            // InserareConcediu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbInlocuitor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFinalConcediu);
            this.Controls.Add(this.dtpInceputConcediu);
            this.Controls.Add(this.cbTipConcediu);
            this.Name = "InserareConcediu";
            this.Text = "InserareConcediu";
            this.Load += new System.EventHandler(this.InserareConcediu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbInlocuitor;
    }
}