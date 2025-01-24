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
            label1 = new Label();
            SelectButton1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            UsingBox1 = new RichTextBox();
            SearchBox = new RichTextBox();
            UsingCheckBox1 = new CheckBox();
            SelectButton2 = new Button();
            UsingBox2 = new RichTextBox();
            UsingCheckBox2 = new CheckBox();
            UsingLabel = new Label();
            EditButton1 = new Button();
            EditButton2 = new Button();
            RadioPanel = new Panel();
            OptionNone = new RadioButton();
            OptionAlpha = new RadioButton();
            OrderingLabel = new Label();
            label2 = new Label();
            RadioPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ListBox
            // 
            ListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListBox.BackColor = SystemColors.ActiveCaptionText;
            ListBox.Cursor = Cursors.IBeam;
            ListBox.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBox.ForeColor = Color.Lime;
            ListBox.Location = new Point(13, 52);
            ListBox.Name = "ListBox";
            ListBox.ReadOnly = true;
            ListBox.Size = new Size(1110, 455);
            ListBox.TabIndex = 0;
            ListBox.Text = "";
            ListBox.TextChanged += ListBox_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(13, 515);
            label1.Name = "label1";
            label1.Size = new Size(817, 39);
            label1.TabIndex = 2;
            // 
            // SelectButton1
            // 
            SelectButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SelectButton1.Location = new Point(144, 522);
            SelectButton1.Name = "SelectButton1";
            SelectButton1.Size = new Size(66, 23);
            SelectButton1.TabIndex = 3;
            SelectButton1.Text = "Select";
            SelectButton1.UseVisualStyleBackColor = true;
            SelectButton1.Click += SelectButton1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.InitialDirectory = "openFileDialog1";
            // 
            // UsingBox1
            // 
            UsingBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UsingBox1.Enabled = false;
            UsingBox1.Location = new Point(279, 522);
            UsingBox1.Multiline = false;
            UsingBox1.Name = "UsingBox1";
            UsingBox1.ReadOnly = true;
            UsingBox1.Size = new Size(164, 23);
            UsingBox1.TabIndex = 4;
            UsingBox1.Text = "";
            UsingBox1.TextChanged += UsingBox1_TextChanged;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.BackColor = SystemColors.ActiveCaptionText;
            SearchBox.Cursor = Cursors.IBeam;
            SearchBox.DetectUrls = false;
            SearchBox.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBox.ForeColor = Color.White;
            SearchBox.Location = new Point(13, 11);
            SearchBox.Multiline = false;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(1110, 31);
            SearchBox.TabIndex = 5;
            SearchBox.Text = "";
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // UsingCheckBox1
            // 
            UsingCheckBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UsingCheckBox1.AutoSize = true;
            UsingCheckBox1.Location = new Point(449, 526);
            UsingCheckBox1.Name = "UsingCheckBox1";
            UsingCheckBox1.Size = new Size(15, 14);
            UsingCheckBox1.TabIndex = 6;
            UsingCheckBox1.UseVisualStyleBackColor = true;
            UsingCheckBox1.CheckedChanged += UsingCheckBox1_CheckedChanged;
            // 
            // SelectButton2
            // 
            SelectButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SelectButton2.Location = new Point(505, 522);
            SelectButton2.Name = "SelectButton2";
            SelectButton2.Size = new Size(66, 23);
            SelectButton2.TabIndex = 3;
            SelectButton2.Text = "Select";
            SelectButton2.UseVisualStyleBackColor = true;
            SelectButton2.Click += SelectButton2_Click;
            // 
            // UsingBox2
            // 
            UsingBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UsingBox2.Enabled = false;
            UsingBox2.Location = new Point(638, 522);
            UsingBox2.Multiline = false;
            UsingBox2.Name = "UsingBox2";
            UsingBox2.ReadOnly = true;
            UsingBox2.Size = new Size(164, 23);
            UsingBox2.TabIndex = 4;
            UsingBox2.Text = "";
            // 
            // UsingCheckBox2
            // 
            UsingCheckBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UsingCheckBox2.AutoSize = true;
            UsingCheckBox2.Location = new Point(808, 526);
            UsingCheckBox2.Name = "UsingCheckBox2";
            UsingCheckBox2.Size = new Size(15, 14);
            UsingCheckBox2.TabIndex = 6;
            UsingCheckBox2.UseVisualStyleBackColor = true;
            UsingCheckBox2.CheckedChanged += UsingCheckBox2_CheckedChanged;
            // 
            // UsingLabel
            // 
            UsingLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UsingLabel.AutoSize = true;
            UsingLabel.BackColor = SystemColors.ActiveBorder;
            UsingLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            UsingLabel.ForeColor = SystemColors.ActiveCaptionText;
            UsingLabel.Location = new Point(23, 524);
            UsingLabel.Name = "UsingLabel";
            UsingLabel.Size = new Size(92, 19);
            UsingLabel.TabIndex = 1;
            UsingLabel.Text = "Source Files:";
            // 
            // EditButton1
            // 
            EditButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditButton1.Enabled = false;
            EditButton1.Location = new Point(216, 522);
            EditButton1.Name = "EditButton1";
            EditButton1.Size = new Size(55, 23);
            EditButton1.TabIndex = 7;
            EditButton1.Text = "Edit";
            EditButton1.UseVisualStyleBackColor = true;
            EditButton1.Click += EditButton1_Click;
            // 
            // EditButton2
            // 
            EditButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditButton2.Enabled = false;
            EditButton2.Location = new Point(577, 522);
            EditButton2.Name = "EditButton2";
            EditButton2.Size = new Size(55, 23);
            EditButton2.TabIndex = 7;
            EditButton2.Text = "Edit";
            EditButton2.UseVisualStyleBackColor = true;
            EditButton2.Click += EditButton2_Click;
            // 
            // RadioPanel
            // 
            RadioPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RadioPanel.Controls.Add(OptionNone);
            RadioPanel.Controls.Add(OptionAlpha);
            RadioPanel.Controls.Add(OrderingLabel);
            RadioPanel.Location = new Point(848, 521);
            RadioPanel.Name = "RadioPanel";
            RadioPanel.Size = new Size(265, 27);
            RadioPanel.TabIndex = 8;
            // 
            // OptionNone
            // 
            OptionNone.AutoSize = true;
            OptionNone.Location = new Point(203, 4);
            OptionNone.Name = "OptionNone";
            OptionNone.Size = new Size(63, 19);
            OptionNone.TabIndex = 2;
            OptionNone.TabStop = true;
            OptionNone.Text = "Default";
            OptionNone.UseVisualStyleBackColor = true;
            OptionNone.CheckedChanged += OptionNone_CheckedChanged;
            // 
            // OptionAlpha
            // 
            OptionAlpha.AutoSize = true;
            OptionAlpha.Location = new Point(102, 4);
            OptionAlpha.Name = "OptionAlpha";
            OptionAlpha.Size = new Size(91, 19);
            OptionAlpha.TabIndex = 2;
            OptionAlpha.TabStop = true;
            OptionAlpha.Text = "Alphabetical";
            OptionAlpha.UseVisualStyleBackColor = true;
            OptionAlpha.CheckedChanged += OptionAlpha_CheckedChanged;
            // 
            // OrderingLabel
            // 
            OrderingLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OrderingLabel.AutoSize = true;
            OrderingLabel.BackColor = SystemColors.ActiveBorder;
            OrderingLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            OrderingLabel.ForeColor = SystemColors.ActiveCaptionText;
            OrderingLabel.Location = new Point(0, 3);
            OrderingLabel.Name = "OrderingLabel";
            OrderingLabel.Size = new Size(74, 19);
            OrderingLabel.TabIndex = 1;
            OrderingLabel.Text = "Ordering:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(835, 515);
            label2.Name = "label2";
            label2.Size = new Size(288, 39);
            label2.TabIndex = 2;
            // 
            // LookUpForm
            // 
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1134, 561);
            Controls.Add(RadioPanel);
            Controls.Add(SearchBox);
            Controls.Add(EditButton2);
            Controls.Add(EditButton1);
            Controls.Add(label2);
            Controls.Add(UsingCheckBox2);
            Controls.Add(UsingCheckBox1);
            Controls.Add(UsingBox2);
            Controls.Add(SelectButton2);
            Controls.Add(UsingBox1);
            Controls.Add(SelectButton1);
            Controls.Add(UsingLabel);
            Controls.Add(ListBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(60, 80);
            Name = "LookUpForm";
            StartPosition = FormStartPosition.Manual;
            Text = "LookUp";
            Load += PwdForm_Load;
            RadioPanel.ResumeLayout(false);
            RadioPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SelectButton1;
        private OpenFileDialog openFileDialog1;
        private RichTextBox UsingBox1;
        private RichTextBox SearchBox;
        private CheckBox UsingCheckBox1;
        private Button SelectButton2;
        private RichTextBox UsingBox2;
        private CheckBox UsingCheckBox2;
        private Label UsingLabel;
        private Button EditButton1;
        private Button EditButton2;
        private Panel RadioPanel;
        private Label OrderingLabel;
        private RadioButton OptionNone;
        private RadioButton OptionAlpha;
        private Label label2;
    }
}