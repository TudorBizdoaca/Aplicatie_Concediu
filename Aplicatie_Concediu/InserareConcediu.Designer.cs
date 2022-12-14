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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserareConcediu));
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelComentarii = new System.Windows.Forms.Label();
            this.labelFinalConcediu = new System.Windows.Forms.Label();
            this.labelStartConcediu = new System.Windows.Forms.Label();
            this.labelInlocuitor = new System.Windows.Forms.Label();
            this.labelTipConcediu = new System.Windows.Forms.Label();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.labelCerereConcediu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblZileConcediu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.labelNumeUtilizatorLogat = new System.Windows.Forms.Label();
            this.pictureBoxUtilizatorLogat = new System.Windows.Forms.PictureBox();
            this.labelDeconectare = new System.Windows.Forms.Label();
            this.buttonIstoricConcedii = new System.Windows.Forms.Button();
            this.buttonPanouAdmin = new System.Windows.Forms.Button();
            this.buttonDetaliiAngajati = new System.Windows.Forms.Button();
            this.buttonCerereConcediu = new System.Windows.Forms.Button();
            this.buttonPaginaMea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatorLogat)).BeginInit();
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
            this.cbTipConcediu.Location = new System.Drawing.Point(187, 4);
            this.cbTipConcediu.Margin = new System.Windows.Forms.Padding(4, 4, 50, 4);
            this.cbTipConcediu.Name = "cbTipConcediu";
            this.cbTipConcediu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTipConcediu.Size = new System.Drawing.Size(221, 33);
            this.cbTipConcediu.TabIndex = 0;
            this.cbTipConcediu.Text = "TipConcediu:";
            this.cbTipConcediu.SelectedIndexChanged += new System.EventHandler(this.cbTipConcediu_SelectedIndexChanged);
            this.cbTipConcediu.SelectionChangeCommitted += new System.EventHandler(this.cbTipConcediu_SelectionChangeCommitted);
            this.cbTipConcediu.SelectedValueChanged += new System.EventHandler(this.cbTipConcediu_SelectedValueChanged);
            // 
            // dtpInceputConcediu
            // 
            this.dtpInceputConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInceputConcediu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInceputConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInceputConcediu.Location = new System.Drawing.Point(187, 79);
            this.dtpInceputConcediu.Margin = new System.Windows.Forms.Padding(4, 4, 50, 4);
            this.dtpInceputConcediu.Name = "dtpInceputConcediu";
            this.dtpInceputConcediu.Size = new System.Drawing.Size(221, 30);
            this.dtpInceputConcediu.TabIndex = 2;
            this.dtpInceputConcediu.ValueChanged += new System.EventHandler(this.dtpInceputConcediu_ValueChanged);
            // 
            // dtpFinalConcediu
            // 
            this.dtpFinalConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFinalConcediu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinalConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinalConcediu.Location = new System.Drawing.Point(645, 79);
            this.dtpFinalConcediu.Margin = new System.Windows.Forms.Padding(4, 4, 50, 4);
            this.dtpFinalConcediu.Name = "dtpFinalConcediu";
            this.dtpFinalConcediu.Size = new System.Drawing.Size(223, 30);
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
            this.cbInlocuitor.Location = new System.Drawing.Point(645, 4);
            this.cbInlocuitor.Margin = new System.Windows.Forms.Padding(4, 4, 50, 4);
            this.cbInlocuitor.Name = "cbInlocuitor";
            this.cbInlocuitor.Size = new System.Drawing.Size(223, 33);
            this.cbInlocuitor.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(718, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
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
            this.rtfComentarii.Location = new System.Drawing.Point(187, 154);
            this.rtfComentarii.Margin = new System.Windows.Forms.Padding(4, 4, 50, 4);
            this.rtfComentarii.MaxLength = 500;
            this.rtfComentarii.Name = "rtfComentarii";
            this.tableLayoutPanel1.SetRowSpan(this.rtfComentarii, 2);
            this.rtfComentarii.Size = new System.Drawing.Size(681, 142);
            this.rtfComentarii.TabIndex = 9;
            this.rtfComentarii.Text = "";
            this.rtfComentarii.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtfComentarii_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
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
            this.tableLayoutPanel1.Controls.Add(this.cbInlocuitor, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtfComentarii, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpFinalConcediu, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpInceputConcediu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCharCount, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(55, 260);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 100);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // labelComentarii
            // 
            this.labelComentarii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelComentarii.AutoSize = true;
            this.labelComentarii.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentarii.ForeColor = System.Drawing.Color.Peru;
            this.labelComentarii.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelComentarii.Location = new System.Drawing.Point(4, 150);
            this.labelComentarii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComentarii.Name = "labelComentarii";
            this.labelComentarii.Size = new System.Drawing.Size(136, 75);
            this.labelComentarii.TabIndex = 17;
            this.labelComentarii.Text = "Comentarii:";
            this.labelComentarii.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFinalConcediu
            // 
            this.labelFinalConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFinalConcediu.AutoSize = true;
            this.labelFinalConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalConcediu.ForeColor = System.Drawing.Color.Peru;
            this.labelFinalConcediu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelFinalConcediu.Location = new System.Drawing.Point(462, 75);
            this.labelFinalConcediu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFinalConcediu.Name = "labelFinalConcediu";
            this.labelFinalConcediu.Size = new System.Drawing.Size(122, 75);
            this.labelFinalConcediu.TabIndex = 16;
            this.labelFinalConcediu.Text = "Final Concediu:";
            this.labelFinalConcediu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStartConcediu
            // 
            this.labelStartConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStartConcediu.AutoSize = true;
            this.labelStartConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartConcediu.ForeColor = System.Drawing.Color.Peru;
            this.labelStartConcediu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelStartConcediu.Location = new System.Drawing.Point(4, 75);
            this.labelStartConcediu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartConcediu.Name = "labelStartConcediu";
            this.labelStartConcediu.Size = new System.Drawing.Size(122, 75);
            this.labelStartConcediu.TabIndex = 15;
            this.labelStartConcediu.Text = "Start Concediu:";
            this.labelStartConcediu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInlocuitor
            // 
            this.labelInlocuitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInlocuitor.AutoSize = true;
            this.labelInlocuitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInlocuitor.ForeColor = System.Drawing.Color.Peru;
            this.labelInlocuitor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelInlocuitor.Location = new System.Drawing.Point(462, 0);
            this.labelInlocuitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInlocuitor.Name = "labelInlocuitor";
            this.labelInlocuitor.Size = new System.Drawing.Size(117, 75);
            this.labelInlocuitor.TabIndex = 14;
            this.labelInlocuitor.Text = "Inlocuitor:";
            this.labelInlocuitor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTipConcediu
            // 
            this.labelTipConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTipConcediu.AutoSize = true;
            this.labelTipConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipConcediu.ForeColor = System.Drawing.Color.Peru;
            this.labelTipConcediu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTipConcediu.Location = new System.Drawing.Point(4, 0);
            this.labelTipConcediu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipConcediu.Name = "labelTipConcediu";
            this.labelTipConcediu.Size = new System.Drawing.Size(164, 75);
            this.labelTipConcediu.TabIndex = 13;
            this.labelTipConcediu.Text = "Tip Concediu:";
            this.labelTipConcediu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCharCount
            // 
            this.lblCharCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.lblCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount.ForeColor = System.Drawing.Color.Peru;
            this.lblCharCount.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCharCount.Location = new System.Drawing.Point(656, 304);
            this.lblCharCount.Margin = new System.Windows.Forms.Padding(4, 4, 50, 4);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(212, 12);
            this.lblCharCount.TabIndex = 11;
            this.lblCharCount.Text = "Caractere ramase: 500";
            this.lblCharCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCerereConcediu
            // 
            this.labelCerereConcediu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCerereConcediu.AutoSize = true;
            this.labelCerereConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCerereConcediu.ForeColor = System.Drawing.Color.Peru;
            this.labelCerereConcediu.Location = new System.Drawing.Point(50, 75);
            this.labelCerereConcediu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 75);
            this.labelCerereConcediu.Name = "labelCerereConcediu";
            this.labelCerereConcediu.Size = new System.Drawing.Size(234, 31);
            this.labelCerereConcediu.TabIndex = 13;
            this.labelCerereConcediu.Text = "Cerere Concediu";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.lblZileConcediu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.labelCerereConcediu);
            this.panel1.Location = new System.Drawing.Point(313, 242);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 75, 50, 50);
            this.panel1.Size = new System.Drawing.Size(1023, 493);
            this.panel1.TabIndex = 39;
            // 
            // lblZileConcediu
            // 
            this.lblZileConcediu.AutoSize = true;
            this.lblZileConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblZileConcediu.ForeColor = System.Drawing.Color.Peru;
            this.lblZileConcediu.Location = new System.Drawing.Point(354, 181);
            this.lblZileConcediu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZileConcediu.Name = "lblZileConcediu";
            this.lblZileConcediu.Size = new System.Drawing.Size(85, 29);
            this.lblZileConcediu.TabIndex = 40;
            this.lblZileConcediu.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(50, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Zile Concediu ramase:";
            // 
            // panelBackground
            // 
            this.panelBackground.AutoSize = true;
            this.panelBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(111)))));
            this.panelBackground.Controls.Add(this.pictureBoxLogo);
            this.panelBackground.Controls.Add(this.buttonIesire);
            this.panelBackground.Controls.Add(this.tableLayoutPanel2);
            this.panelBackground.Controls.Add(this.buttonIstoricConcedii);
            this.panelBackground.Controls.Add(this.buttonPanouAdmin);
            this.panelBackground.Controls.Add(this.buttonDetaliiAngajati);
            this.panelBackground.Controls.Add(this.buttonCerereConcediu);
            this.panelBackground.Controls.Add(this.buttonPaginaMea);
            this.panelBackground.Controls.Add(this.panel1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(51, 50, 51, 50);
            this.panelBackground.Size = new System.Drawing.Size(1387, 788);
            this.panelBackground.TabIndex = 40;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(51, 9);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(211, 228);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 40;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonIesire
            // 
            this.buttonIesire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIesire.ForeColor = System.Drawing.Color.Peru;
            this.buttonIesire.Location = new System.Drawing.Point(1291, 50);
            this.buttonIesire.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(45, 39);
            this.buttonIesire.TabIndex = 37;
            this.buttonIesire.Text = "X";
            this.buttonIesire.UseVisualStyleBackColor = false;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.22946F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.77054F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel2.Controls.Add(this.labelSeparator, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelNumeUtilizatorLogat, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxUtilizatorLogat, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelDeconectare, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(771, 114);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(565, 76);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // labelSeparator
            // 
            this.labelSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeparator.AutoSize = true;
            this.labelSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeparator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSeparator.Location = new System.Drawing.Point(286, 0);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(26, 76);
            this.labelSeparator.TabIndex = 38;
            this.labelSeparator.Text = "|";
            this.labelSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumeUtilizatorLogat
            // 
            this.labelNumeUtilizatorLogat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumeUtilizatorLogat.AutoSize = true;
            this.labelNumeUtilizatorLogat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeUtilizatorLogat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNumeUtilizatorLogat.Location = new System.Drawing.Point(68, 0);
            this.labelNumeUtilizatorLogat.Name = "labelNumeUtilizatorLogat";
            this.labelNumeUtilizatorLogat.Size = new System.Drawing.Size(212, 76);
            this.labelNumeUtilizatorLogat.TabIndex = 37;
            this.labelNumeUtilizatorLogat.Text = "Nume Utilizator";
            this.labelNumeUtilizatorLogat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNumeUtilizatorLogat.Click += new System.EventHandler(this.labelNumeUtilizatorLogat_Click);
            // 
            // pictureBoxUtilizatorLogat
            // 
            this.pictureBoxUtilizatorLogat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUtilizatorLogat.Enabled = false;
            this.pictureBoxUtilizatorLogat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUtilizatorLogat.Image")));
            this.pictureBoxUtilizatorLogat.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxUtilizatorLogat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUtilizatorLogat.Name = "pictureBoxUtilizatorLogat";
            this.pictureBoxUtilizatorLogat.Size = new System.Drawing.Size(59, 72);
            this.pictureBoxUtilizatorLogat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUtilizatorLogat.TabIndex = 36;
            this.pictureBoxUtilizatorLogat.TabStop = false;
            this.pictureBoxUtilizatorLogat.Click += new System.EventHandler(this.pictureBoxUtilizatorLogat_Click);
            // 
            // labelDeconectare
            // 
            this.labelDeconectare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeconectare.AutoSize = true;
            this.labelDeconectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeconectare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDeconectare.Location = new System.Drawing.Point(318, 0);
            this.labelDeconectare.Name = "labelDeconectare";
            this.labelDeconectare.Size = new System.Drawing.Size(244, 76);
            this.labelDeconectare.TabIndex = 36;
            this.labelDeconectare.Text = "Deconectare";
            this.labelDeconectare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDeconectare.Click += new System.EventHandler(this.labelDeconectare_Click);
            // 
            // buttonIstoricConcedii
            // 
            this.buttonIstoricConcedii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonIstoricConcedii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIstoricConcedii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIstoricConcedii.ForeColor = System.Drawing.Color.Peru;
            this.buttonIstoricConcedii.Location = new System.Drawing.Point(51, 432);
            this.buttonIstoricConcedii.Margin = new System.Windows.Forms.Padding(0, 0, 51, 25);
            this.buttonIstoricConcedii.Name = "buttonIstoricConcedii";
            this.buttonIstoricConcedii.Size = new System.Drawing.Size(211, 68);
            this.buttonIstoricConcedii.TabIndex = 19;
            this.buttonIstoricConcedii.Text = "Istoric Concedii";
            this.buttonIstoricConcedii.UseVisualStyleBackColor = false;
            this.buttonIstoricConcedii.Click += new System.EventHandler(this.buttonIstoricConcedii_Click);
            // 
            // buttonPanouAdmin
            // 
            this.buttonPanouAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonPanouAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPanouAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPanouAdmin.ForeColor = System.Drawing.Color.Peru;
            this.buttonPanouAdmin.Location = new System.Drawing.Point(51, 620);
            this.buttonPanouAdmin.Margin = new System.Windows.Forms.Padding(0, 0, 51, 25);
            this.buttonPanouAdmin.Name = "buttonPanouAdmin";
            this.buttonPanouAdmin.Size = new System.Drawing.Size(211, 70);
            this.buttonPanouAdmin.TabIndex = 18;
            this.buttonPanouAdmin.Text = "Concedii";
            this.buttonPanouAdmin.UseVisualStyleBackColor = false;
            this.buttonPanouAdmin.Visible = false;
            this.buttonPanouAdmin.Click += new System.EventHandler(this.buttonPanouAdmin_Click);
            // 
            // buttonDetaliiAngajati
            // 
            this.buttonDetaliiAngajati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonDetaliiAngajati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetaliiAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetaliiAngajati.ForeColor = System.Drawing.Color.Peru;
            this.buttonDetaliiAngajati.Location = new System.Drawing.Point(51, 525);
            this.buttonDetaliiAngajati.Margin = new System.Windows.Forms.Padding(0, 0, 51, 25);
            this.buttonDetaliiAngajati.Name = "buttonDetaliiAngajati";
            this.buttonDetaliiAngajati.Size = new System.Drawing.Size(211, 70);
            this.buttonDetaliiAngajati.TabIndex = 17;
            this.buttonDetaliiAngajati.Text = "Detalii Angajati";
            this.buttonDetaliiAngajati.UseVisualStyleBackColor = false;
            this.buttonDetaliiAngajati.Visible = false;
            this.buttonDetaliiAngajati.Click += new System.EventHandler(this.buttonDetaliiAngajati_Click);
            // 
            // buttonCerereConcediu
            // 
            this.buttonCerereConcediu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(133)))), ((int)(((byte)(78)))));
            this.buttonCerereConcediu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerereConcediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerereConcediu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCerereConcediu.Location = new System.Drawing.Point(51, 337);
            this.buttonCerereConcediu.Margin = new System.Windows.Forms.Padding(0, 0, 51, 25);
            this.buttonCerereConcediu.Name = "buttonCerereConcediu";
            this.buttonCerereConcediu.Size = new System.Drawing.Size(211, 70);
            this.buttonCerereConcediu.TabIndex = 16;
            this.buttonCerereConcediu.Text = "Cerere Concediu";
            this.buttonCerereConcediu.UseVisualStyleBackColor = false;
            this.buttonCerereConcediu.Click += new System.EventHandler(this.buttonCerereConcediu_Click);
            // 
            // buttonPaginaMea
            // 
            this.buttonPaginaMea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.buttonPaginaMea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaginaMea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaginaMea.ForeColor = System.Drawing.Color.Peru;
            this.buttonPaginaMea.Location = new System.Drawing.Point(51, 242);
            this.buttonPaginaMea.Margin = new System.Windows.Forms.Padding(0, 0, 51, 25);
            this.buttonPaginaMea.Name = "buttonPaginaMea";
            this.buttonPaginaMea.Size = new System.Drawing.Size(211, 70);
            this.buttonPaginaMea.TabIndex = 15;
            this.buttonPaginaMea.Text = "Pagina Mea";
            this.buttonPaginaMea.UseVisualStyleBackColor = false;
            this.buttonPaginaMea.Click += new System.EventHandler(this.buttonPaginaMea_Click);
            // 
            // InserareConcediu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InserareConcediu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InserareConcediu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InserareConcediu_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.breakingBreadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipConcediuBindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizatorLogat)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCerereConcediu;
        private System.Windows.Forms.Label labelStartConcediu;
        private System.Windows.Forms.Label labelInlocuitor;
        private System.Windows.Forms.Label labelTipConcediu;
        private System.Windows.Forms.Label labelComentarii;
        private System.Windows.Forms.Label labelFinalConcediu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button buttonIesire;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.Label labelNumeUtilizatorLogat;
        private System.Windows.Forms.PictureBox pictureBoxUtilizatorLogat;
        private System.Windows.Forms.Label labelDeconectare;
        private System.Windows.Forms.Label lblZileConcediu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonIstoricConcedii;
        private System.Windows.Forms.Button buttonPanouAdmin;
        private System.Windows.Forms.Button buttonDetaliiAngajati;
        private System.Windows.Forms.Button buttonCerereConcediu;
        private System.Windows.Forms.Button buttonPaginaMea;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblCharCount;
    }
}