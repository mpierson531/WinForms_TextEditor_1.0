namespace WinFormsApp_Test1_TextEditor
{
    public partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.textAreaBox = new System.Windows.Forms.RichTextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.fileNameField = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameFieldFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allFontsChangesEverythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineCharacterCountFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lineCountLabel = new System.Windows.Forms.Label();
            this.characterCountLabel = new System.Windows.Forms.Label();
            this.changeDirectoryButton = new System.Windows.Forms.Button();
            this.mouseDrawingButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textAreaBox
            // 
            this.textAreaBox.AcceptsTab = true;
            this.textAreaBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAreaBox.AutoWordSelection = true;
            this.textAreaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAreaBox.Location = new System.Drawing.Point(10, 28);
            this.textAreaBox.Margin = new System.Windows.Forms.Padding(1);
            this.textAreaBox.Name = "textAreaBox";
            this.textAreaBox.Size = new System.Drawing.Size(1170, 509);
            this.textAreaBox.TabIndex = 0;
            this.textAreaBox.Text = "Type Here";
            this.textAreaBox.TextChanged += new System.EventHandler(this.textAreaBox_TextChanged);
            // 
            // openButton
            // 
            this.openButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.openButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openButton.FlatAppearance.BorderSize = 2;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openButton.Location = new System.Drawing.Point(570, 0);
            this.openButton.Margin = new System.Windows.Forms.Padding(1);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(91, 28);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(670, 0);
            this.saveButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 28);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // fileNameField
            // 
            this.fileNameField.AcceptsReturn = true;
            this.fileNameField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fileNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileNameField.Location = new System.Drawing.Point(385, 0);
            this.fileNameField.Margin = new System.Windows.Forms.Padding(1);
            this.fileNameField.Name = "fileNameField";
            this.fileNameField.Size = new System.Drawing.Size(172, 26);
            this.fileNameField.TabIndex = 3;
            this.fileNameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fileNameLabel.AutoEllipsis = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileNameLabel.Location = new System.Drawing.Point(280, 0);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(1);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(106, 28);
            this.fileNameLabel.TabIndex = 4;
            this.fileNameLabel.Text = "File Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveMenuItem);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenMenuItem);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // fontMenuItem
            // 
            this.fontMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainFontToolStripMenuItem,
            this.nameFieldFontToolStripMenuItem,
            this.allFontsChangesEverythingToolStripMenuItem,
            this.lineCharacterCountFontToolStripMenuItem});
            this.fontMenuItem.Name = "fontMenuItem";
            this.fontMenuItem.Size = new System.Drawing.Size(121, 26);
            this.fontMenuItem.Text = "Font";
            // 
            // mainFontToolStripMenuItem
            // 
            this.mainFontToolStripMenuItem.Name = "mainFontToolStripMenuItem";
            this.mainFontToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.mainFontToolStripMenuItem.Text = "Main Font";
            this.mainFontToolStripMenuItem.Click += new System.EventHandler(this.MainFontItem_Click);
            // 
            // nameFieldFontToolStripMenuItem
            // 
            this.nameFieldFontToolStripMenuItem.Name = "nameFieldFontToolStripMenuItem";
            this.nameFieldFontToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.nameFieldFontToolStripMenuItem.Text = "Name Field Font";
            this.nameFieldFontToolStripMenuItem.Click += new System.EventHandler(this.NameFieldFontItem_Click);
            // 
            // allFontsChangesEverythingToolStripMenuItem
            // 
            this.allFontsChangesEverythingToolStripMenuItem.Name = "allFontsChangesEverythingToolStripMenuItem";
            this.allFontsChangesEverythingToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.allFontsChangesEverythingToolStripMenuItem.Text = "All Fonts (Changes Everything)";
            this.allFontsChangesEverythingToolStripMenuItem.Click += new System.EventHandler(this.AllFontsItem_Click);
            // 
            // lineCharacterCountFontToolStripMenuItem
            // 
            this.lineCharacterCountFontToolStripMenuItem.Name = "lineCharacterCountFontToolStripMenuItem";
            this.lineCharacterCountFontToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.lineCharacterCountFontToolStripMenuItem.Text = "Line/Character Count Font";
            this.lineCharacterCountFontToolStripMenuItem.Click += new System.EventHandler(this.lineCharacterCountFontToolStripMenuItem_Click);
            // 
            // lineCountLabel
            // 
            this.lineCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lineCountLabel.AutoEllipsis = true;
            this.lineCountLabel.AutoSize = true;
            this.lineCountLabel.Location = new System.Drawing.Point(0, 533);
            this.lineCountLabel.Name = "lineCountLabel";
            this.lineCountLabel.Size = new System.Drawing.Size(0, 25);
            this.lineCountLabel.TabIndex = 6;
            // 
            // characterCountLabel
            // 
            this.characterCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.characterCountLabel.AutoEllipsis = true;
            this.characterCountLabel.AutoSize = true;
            this.characterCountLabel.Location = new System.Drawing.Point(90, 533);
            this.characterCountLabel.Name = "characterCountLabel";
            this.characterCountLabel.Size = new System.Drawing.Size(0, 25);
            this.characterCountLabel.TabIndex = 7;
            // 
            // changeDirectoryButton
            // 
            this.changeDirectoryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.changeDirectoryButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeDirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeDirectoryButton.Location = new System.Drawing.Point(770, 0);
            this.changeDirectoryButton.Margin = new System.Windows.Forms.Padding(1);
            this.changeDirectoryButton.Name = "changeDirectoryButton";
            this.changeDirectoryButton.Size = new System.Drawing.Size(148, 28);
            this.changeDirectoryButton.TabIndex = 8;
            this.changeDirectoryButton.Text = "Change Directory";
            this.changeDirectoryButton.UseVisualStyleBackColor = false;
            this.changeDirectoryButton.Click += new System.EventHandler(this.changeDirectoryButton_Click);
            // 
            // mouseDrawingButton
            // 
            this.mouseDrawingButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mouseDrawingButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mouseDrawingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mouseDrawingButton.Location = new System.Drawing.Point(0, 534);
            this.mouseDrawingButton.Name = "mouseDrawingButton";
            this.mouseDrawingButton.Size = new System.Drawing.Size(1200, 28);
            this.mouseDrawingButton.TabIndex = 9;
            this.mouseDrawingButton.Text = "Activate Mouse Drawing";
            this.mouseDrawingButton.UseVisualStyleBackColor = false;
            this.mouseDrawingButton.Click += new System.EventHandler(this.mouseDrawingButton_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 562);
            this.Controls.Add(this.mouseDrawingButton);
            this.Controls.Add(this.changeDirectoryButton);
            this.Controls.Add(this.characterCountLabel);
            this.Controls.Add(this.lineCountLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileNameField);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.textAreaBox);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TextEditor";
            this.Text = "Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhenTheFormIsClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public RichTextBox textAreaBox;
        private Button openButton;
        private Button saveButton;
        public TextBox fileNameField;
        private Label fileNameLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem fontMenuItem;
        private FontDialog fontDialog1;
        private ToolStripMenuItem mainFontToolStripMenuItem;
        private ToolStripMenuItem nameFieldFontToolStripMenuItem;
        private ToolStripMenuItem allFontsChangesEverythingToolStripMenuItem;
        private ToolStripMenuItem changeCurrentDirectoryMenuItem;
        private Label lineCountLabel;
        private Label characterCountLabel;
        private Button changeDirectoryButton;
        private ToolStripMenuItem lineCharacterCountFontToolStripMenuItem;
        private Button mouseDrawingButton;
    }
}