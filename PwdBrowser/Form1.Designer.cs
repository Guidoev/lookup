namespace PwdBrowser
{
    partial class LookUpForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpForm));
            ListBox = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            UsingBox1 = new RichTextBox();
            UsingCheckBox1 = new CheckBox();
            SelectButton2 = new Button();
            UsingBox2 = new RichTextBox();
            UsingCheckBox2 = new CheckBox();
            UsingLabel = new Label();
            EditButton1 = new Button();
            EditButton2 = new Button();
            HelpButton = new Button();
            SearchBox = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SelectButton1 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            OrderingLabel = new Label();
            OptionNone = new RadioButton();
            OptionAlpha = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // ListBox
            // 
            ListBox.BackColor = SystemColors.ActiveCaptionText;
            ListBox.Cursor = Cursors.IBeam;
            ListBox.Dock = DockStyle.Fill;
            ListBox.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBox.ForeColor = Color.Lime;
            ListBox.Location = new Point(6, 46);
            ListBox.Name = "ListBox";
            ListBox.ReadOnly = true;
            ListBox.Size = new Size(1075, 439);
            ListBox.TabIndex = 0;
            ListBox.Text = "";
            ListBox.LinkClicked += ListBox_LinkClicked;
            ListBox.TextChanged += ListBox_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.InitialDirectory = "openFileDialog1";
            // 
            // UsingBox1
            // 
            UsingBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UsingBox1.Enabled = false;
            UsingBox1.Location = new Point(134, 6);
            UsingBox1.Margin = new Padding(2, 0, 2, 0);
            UsingBox1.Multiline = false;
            UsingBox1.Name = "UsingBox1";
            UsingBox1.ReadOnly = true;
            UsingBox1.Size = new Size(165, 23);
            UsingBox1.TabIndex = 4;
            UsingBox1.Text = "";
            UsingBox1.WordWrap = false;
            UsingBox1.TextChanged += UsingBox1_TextChanged;
            // 
            // UsingCheckBox1
            // 
            UsingCheckBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UsingCheckBox1.AutoSize = true;
            UsingCheckBox1.Location = new Point(304, 10);
            UsingCheckBox1.Margin = new Padding(3, 0, 10, 0);
            UsingCheckBox1.Name = "UsingCheckBox1";
            UsingCheckBox1.Size = new Size(15, 14);
            UsingCheckBox1.TabIndex = 6;
            UsingCheckBox1.UseVisualStyleBackColor = true;
            UsingCheckBox1.CheckedChanged += UsingCheckBox1_CheckedChanged;
            // 
            // SelectButton2
            // 
            SelectButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SelectButton2.AutoSize = true;
            SelectButton2.Location = new Point(331, 5);
            SelectButton2.Margin = new Padding(2, 0, 2, 0);
            SelectButton2.Name = "SelectButton2";
            SelectButton2.Size = new Size(66, 25);
            SelectButton2.TabIndex = 3;
            SelectButton2.Text = "Select";
            SelectButton2.UseVisualStyleBackColor = true;
            SelectButton2.Click += SelectButton2_Click;
            // 
            // UsingBox2
            // 
            UsingBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UsingBox2.Enabled = false;
            UsingBox2.Location = new Point(460, 6);
            UsingBox2.Margin = new Padding(2, 0, 2, 0);
            UsingBox2.Multiline = false;
            UsingBox2.Name = "UsingBox2";
            UsingBox2.ReadOnly = true;
            UsingBox2.Size = new Size(165, 23);
            UsingBox2.TabIndex = 4;
            UsingBox2.Text = "";
            UsingBox2.WordWrap = false;
            // 
            // UsingCheckBox2
            // 
            UsingCheckBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UsingCheckBox2.AutoSize = true;
            UsingCheckBox2.Location = new Point(630, 10);
            UsingCheckBox2.Margin = new Padding(3, 0, 0, 0);
            UsingCheckBox2.Name = "UsingCheckBox2";
            UsingCheckBox2.Size = new Size(15, 14);
            UsingCheckBox2.TabIndex = 6;
            UsingCheckBox2.UseVisualStyleBackColor = true;
            UsingCheckBox2.CheckedChanged += UsingCheckBox2_CheckedChanged;
            // 
            // UsingLabel
            // 
            UsingLabel.Anchor = AnchorStyles.Left;
            UsingLabel.AutoSize = true;
            UsingLabel.BackColor = SystemColors.ActiveBorder;
            UsingLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            UsingLabel.ForeColor = SystemColors.ActiveCaptionText;
            UsingLabel.Location = new Point(3, 10);
            UsingLabel.Name = "UsingLabel";
            UsingLabel.Size = new Size(92, 19);
            UsingLabel.TabIndex = 1;
            UsingLabel.Text = "Source Files:";
            UsingLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EditButton1
            // 
            EditButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditButton1.AutoSize = true;
            EditButton1.Enabled = false;
            EditButton1.Location = new Point(75, 5);
            EditButton1.Margin = new Padding(2, 0, 2, 0);
            EditButton1.Name = "EditButton1";
            EditButton1.Size = new Size(55, 25);
            EditButton1.TabIndex = 7;
            EditButton1.Text = "Edit";
            EditButton1.UseVisualStyleBackColor = true;
            EditButton1.Click += EditButton1_Click;
            // 
            // EditButton2
            // 
            EditButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EditButton2.AutoSize = true;
            EditButton2.Enabled = false;
            EditButton2.Location = new Point(401, 5);
            EditButton2.Margin = new Padding(2, 0, 2, 0);
            EditButton2.Name = "EditButton2";
            EditButton2.Size = new Size(55, 25);
            EditButton2.TabIndex = 7;
            EditButton2.Text = "Edit";
            EditButton2.UseVisualStyleBackColor = true;
            EditButton2.Click += EditButton2_Click;
            // 
            // HelpButton
            // 
            HelpButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            HelpButton.Location = new Point(1030, 7);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(42, 25);
            HelpButton.TabIndex = 10;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.BackColor = SystemColors.ActiveCaptionText;
            SearchBox.Cursor = Cursors.IBeam;
            SearchBox.DetectUrls = false;
            SearchBox.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBox.ForeColor = Color.White;
            SearchBox.Location = new Point(6, 6);
            SearchBox.Multiline = false;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(1075, 34);
            SearchBox.TabIndex = 5;
            SearchBox.Text = "";
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(SearchBox, 0, 0);
            tableLayoutPanel1.Controls.Add(ListBox, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1087, 536);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel2.Controls.Add(UsingLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(HelpButton, 3, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(6, 491);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1075, 39);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(SelectButton1);
            flowLayoutPanel1.Controls.Add(EditButton1);
            flowLayoutPanel1.Controls.Add(UsingBox1);
            flowLayoutPanel1.Controls.Add(UsingCheckBox1);
            flowLayoutPanel1.Controls.Add(SelectButton2);
            flowLayoutPanel1.Controls.Add(EditButton2);
            flowLayoutPanel1.Controls.Add(UsingBox2);
            flowLayoutPanel1.Controls.Add(UsingCheckBox2);
            flowLayoutPanel1.Location = new Point(101, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(3, 5, 3, 3);
            flowLayoutPanel1.Size = new Size(671, 33);
            flowLayoutPanel1.TabIndex = 11;
            flowLayoutPanel1.WrapContents = false;
            // 
            // SelectButton1
            // 
            SelectButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SelectButton1.AutoSize = true;
            SelectButton1.Location = new Point(5, 5);
            SelectButton1.Margin = new Padding(2, 0, 2, 0);
            SelectButton1.Name = "SelectButton1";
            SelectButton1.Size = new Size(66, 25);
            SelectButton1.TabIndex = 12;
            SelectButton1.Text = "Select";
            SelectButton1.UseVisualStyleBackColor = true;
            SelectButton1.Click += SelectButton1_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.None;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(OrderingLabel);
            flowLayoutPanel2.Controls.Add(OptionNone);
            flowLayoutPanel2.Controls.Add(OptionAlpha);
            flowLayoutPanel2.Location = new Point(778, 7);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(246, 25);
            flowLayoutPanel2.TabIndex = 12;
            flowLayoutPanel2.WrapContents = false;
            // 
            // OrderingLabel
            // 
            OrderingLabel.Anchor = AnchorStyles.Left;
            OrderingLabel.AutoSize = true;
            OrderingLabel.BackColor = Color.Transparent;
            OrderingLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            OrderingLabel.ForeColor = SystemColors.ActiveCaptionText;
            OrderingLabel.Location = new Point(3, 3);
            OrderingLabel.Name = "OrderingLabel";
            OrderingLabel.Size = new Size(74, 19);
            OrderingLabel.TabIndex = 3;
            OrderingLabel.Text = "Ordering:";
            OrderingLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OptionNone
            // 
            OptionNone.Anchor = AnchorStyles.Left;
            OptionNone.AutoSize = true;
            OptionNone.BackColor = Color.Transparent;
            OptionNone.Location = new Point(83, 3);
            OptionNone.Name = "OptionNone";
            OptionNone.Size = new Size(63, 19);
            OptionNone.TabIndex = 5;
            OptionNone.TabStop = true;
            OptionNone.Text = "Default";
            OptionNone.UseVisualStyleBackColor = false;
            OptionNone.CheckedChanged += OptionNone_CheckedChanged;
            // 
            // OptionAlpha
            // 
            OptionAlpha.AutoSize = true;
            OptionAlpha.Location = new Point(152, 3);
            OptionAlpha.Name = "OptionAlpha";
            OptionAlpha.Size = new Size(91, 19);
            OptionAlpha.TabIndex = 4;
            OptionAlpha.TabStop = true;
            OptionAlpha.Text = "Alphabetical";
            OptionAlpha.UseVisualStyleBackColor = true;
            OptionAlpha.CheckedChanged += OptionAlpha_CheckedChanged;
            // 
            // LookUpForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1093, 542);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(60, 80);
            Name = "LookUpForm";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.Manual;
            Text = "LookUp";
            Load += PwdForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private RichTextBox UsingBox1;
        private CheckBox UsingCheckBox1;
        private Button SelectButton2;
        private RichTextBox UsingBox2;
        private CheckBox UsingCheckBox2;
        private Label UsingLabel;
        private Button EditButton1;
        private Button EditButton2;
        private Button HelpButton;
        private RichTextBox SearchBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button SelectButton1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label OrderingLabel;
        private RadioButton OptionNone;
        private RadioButton OptionAlpha;
    }
}