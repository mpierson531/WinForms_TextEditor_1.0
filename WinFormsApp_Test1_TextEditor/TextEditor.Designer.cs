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
            this.editorBox = new System.Windows.Forms.RichTextBox();
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
            this.ChooseDirectoryButton = new System.Windows.Forms.Button();
            this.EnableDrawingButton = new System.Windows.Forms.Button();
            this.DrawSettingsPanel = new System.Windows.Forms.Panel();
            this.FilledCheckBox = new System.Windows.Forms.CheckBox();
            this.FilledLabel = new System.Windows.Forms.Label();
            this.ThicknessLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ShapeLabel = new System.Windows.Forms.Label();
            this.ThicknessBox = new System.Windows.Forms.ComboBox();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.ShapeBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.DrawSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorBox
            // 
            this.editorBox.AcceptsTab = true;
            this.editorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorBox.AutoWordSelection = true;
            this.editorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editorBox.Location = new System.Drawing.Point(10, 28);
            this.editorBox.Margin = new System.Windows.Forms.Padding(1);
            this.editorBox.Name = "editorBox";
            this.editorBox.Size = new System.Drawing.Size(1170, 500);
            this.editorBox.TabIndex = 0;
            this.editorBox.Text = "Type Here";
            this.editorBox.TextChanged += new System.EventHandler(this.textAreaBox_TextChanged);
            // 
            // openButton
            // 
            this.openButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.openButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openButton.FlatAppearance.BorderSize = 2;
            this.openButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.openButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.saveButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileNameLabel.Location = new System.Drawing.Point(291, 3);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(1);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(92, 20);
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
            this.menuStrip1.Size = new System.Drawing.Size(1200, 30);
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
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveMenuItem);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenMenuItem);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
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
            this.fontMenuItem.Size = new System.Drawing.Size(128, 26);
            this.fontMenuItem.Text = "Font";
            // 
            // mainFontToolStripMenuItem
            // 
            this.mainFontToolStripMenuItem.Name = "mainFontToolStripMenuItem";
            this.mainFontToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.mainFontToolStripMenuItem.Text = "Main Font";
            this.mainFontToolStripMenuItem.Click += new System.EventHandler(this.MainFontItem_Click);
            // 
            // nameFieldFontToolStripMenuItem
            // 
            this.nameFieldFontToolStripMenuItem.Name = "nameFieldFontToolStripMenuItem";
            this.nameFieldFontToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.nameFieldFontToolStripMenuItem.Text = "Name Field Font";
            this.nameFieldFontToolStripMenuItem.Click += new System.EventHandler(this.NameFieldFontItem_Click);
            // 
            // allFontsChangesEverythingToolStripMenuItem
            // 
            this.allFontsChangesEverythingToolStripMenuItem.Name = "allFontsChangesEverythingToolStripMenuItem";
            this.allFontsChangesEverythingToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.allFontsChangesEverythingToolStripMenuItem.Text = "All Fonts (Changes Everything)";
            this.allFontsChangesEverythingToolStripMenuItem.Click += new System.EventHandler(this.AllFontsItem_Click);
            // 
            // lineCharacterCountFontToolStripMenuItem
            // 
            this.lineCharacterCountFontToolStripMenuItem.Name = "lineCharacterCountFontToolStripMenuItem";
            this.lineCharacterCountFontToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.lineCharacterCountFontToolStripMenuItem.Text = "Line/Character Count Font";
            this.lineCharacterCountFontToolStripMenuItem.Click += new System.EventHandler(this.lineCharacterCountFontMenuItem_Click);
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
            this.changeDirectoryButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeDirectoryButton.Location = new System.Drawing.Point(768, 0);
            this.changeDirectoryButton.Margin = new System.Windows.Forms.Padding(1);
            this.changeDirectoryButton.Name = "changeDirectoryButton";
            this.changeDirectoryButton.Size = new System.Drawing.Size(160, 28);
            this.changeDirectoryButton.TabIndex = 8;
            this.changeDirectoryButton.Text = "Change Directory";
            this.changeDirectoryButton.UseVisualStyleBackColor = false;
            this.changeDirectoryButton.Click += new System.EventHandler(this.changeDirectoryButton_Click);
            // 
            // ChooseDirectoryButton
            // 
            this.ChooseDirectoryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChooseDirectoryButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChooseDirectoryButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseDirectoryButton.Location = new System.Drawing.Point(935, 0);
            this.ChooseDirectoryButton.Name = "ChooseDirectoryButton";
            this.ChooseDirectoryButton.Size = new System.Drawing.Size(156, 28);
            this.ChooseDirectoryButton.TabIndex = 10;
            this.ChooseDirectoryButton.Text = "Choose Directory";
            this.ChooseDirectoryButton.UseVisualStyleBackColor = false;
            this.ChooseDirectoryButton.Click += new System.EventHandler(this.ChooseDirectoryButtonClick);
            // 
            // EnableDrawingButton
            // 
            this.EnableDrawingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EnableDrawingButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnableDrawingButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnableDrawingButton.Location = new System.Drawing.Point(517, 530);
            this.EnableDrawingButton.Name = "EnableDrawingButton";
            this.EnableDrawingButton.Size = new System.Drawing.Size(157, 28);
            this.EnableDrawingButton.TabIndex = 11;
            this.EnableDrawingButton.Text = "Enable Drawing";
            this.EnableDrawingButton.UseVisualStyleBackColor = false;
            this.EnableDrawingButton.Click += new System.EventHandler(this.ActivateDrawingClick);
            // 
            // DrawSettingsPanel
            // 
            this.DrawSettingsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DrawSettingsPanel.Controls.Add(this.FilledCheckBox);
            this.DrawSettingsPanel.Controls.Add(this.FilledLabel);
            this.DrawSettingsPanel.Controls.Add(this.ThicknessLabel);
            this.DrawSettingsPanel.Controls.Add(this.ColorLabel);
            this.DrawSettingsPanel.Controls.Add(this.ShapeLabel);
            this.DrawSettingsPanel.Controls.Add(this.ThicknessBox);
            this.DrawSettingsPanel.Controls.Add(this.ColorBox);
            this.DrawSettingsPanel.Controls.Add(this.ShapeBox);
            this.DrawSettingsPanel.Enabled = false;
            this.DrawSettingsPanel.Location = new System.Drawing.Point(23, 36);
            this.DrawSettingsPanel.Name = "DrawSettingsPanel";
            this.DrawSettingsPanel.Size = new System.Drawing.Size(228, 158);
            this.DrawSettingsPanel.TabIndex = 12;
            this.DrawSettingsPanel.Visible = false;
            // 
            // FilledCheckBox
            // 
            this.FilledCheckBox.AutoSize = true;
            this.FilledCheckBox.Checked = true;
            this.FilledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilledCheckBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilledCheckBox.Location = new System.Drawing.Point(207, 51);
            this.FilledCheckBox.Name = "FilledCheckBox";
            this.FilledCheckBox.Size = new System.Drawing.Size(18, 17);
            this.FilledCheckBox.TabIndex = 7;
            this.FilledCheckBox.UseVisualStyleBackColor = true;
            this.FilledCheckBox.CheckedChanged += new System.EventHandler(this.FilledCheckBoxChanged);
            // 
            // FilledLabel
            // 
            this.FilledLabel.AutoSize = true;
            this.FilledLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilledLabel.Location = new System.Drawing.Point(3, 48);
            this.FilledLabel.Name = "FilledLabel";
            this.FilledLabel.Size = new System.Drawing.Size(49, 22);
            this.FilledLabel.TabIndex = 6;
            this.FilledLabel.Text = "Filled";
            // 
            // ThicknessLabel
            // 
            this.ThicknessLabel.AutoSize = true;
            this.ThicknessLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThicknessLabel.Location = new System.Drawing.Point(3, 128);
            this.ThicknessLabel.Name = "ThicknessLabel";
            this.ThicknessLabel.Size = new System.Drawing.Size(82, 22);
            this.ThicknessLabel.TabIndex = 5;
            this.ThicknessLabel.Text = "Thickness";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColorLabel.Location = new System.Drawing.Point(3, 90);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(51, 22);
            this.ColorLabel.TabIndex = 4;
            this.ColorLabel.Text = "Color";
            // 
            // ShapeLabel
            // 
            this.ShapeLabel.AutoSize = true;
            this.ShapeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShapeLabel.Location = new System.Drawing.Point(3, 8);
            this.ShapeLabel.Name = "ShapeLabel";
            this.ShapeLabel.Size = new System.Drawing.Size(57, 22);
            this.ShapeLabel.TabIndex = 3;
            this.ShapeLabel.Text = "Shape";
            // 
            // ThicknessBox
            // 
            this.ThicknessBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThicknessBox.FormattingEnabled = true;
            this.ThicknessBox.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "125",
            "150",
            "175",
            "200",
            "250",
            "300",
            "350",
            "400",
            "450",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.ThicknessBox.Location = new System.Drawing.Point(159, 124);
            this.ThicknessBox.MaxDropDownItems = 10;
            this.ThicknessBox.Name = "ThicknessBox";
            this.ThicknessBox.Size = new System.Drawing.Size(66, 30);
            this.ThicknessBox.TabIndex = 2;
            this.ThicknessBox.Text = "15";
            this.ThicknessBox.TextUpdate += new System.EventHandler(this.ThicknessBoxChanged);
            this.ThicknessBox.SelectedValueChanged += new System.EventHandler(this.ThicknessBoxChanged);
            // 
            // ColorBox
            // 
            this.ColorBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Green",
            "Orange",
            "Yellow"});
            this.ColorBox.Location = new System.Drawing.Point(114, 84);
            this.ColorBox.MaxDropDownItems = 10;
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(111, 30);
            this.ColorBox.TabIndex = 1;
            this.ColorBox.Text = "Blue";
            this.ColorBox.TextUpdate += new System.EventHandler(this.ColorBoxChanged);
            this.ColorBox.SelectedValueChanged += new System.EventHandler(this.ColorBoxChanged);
            // 
            // ShapeBox
            // 
            this.ShapeBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShapeBox.FormattingEnabled = true;
            this.ShapeBox.Items.AddRange(new object[] {
            "Line",
            "Circle",
            "Rectangle"});
            this.ShapeBox.Location = new System.Drawing.Point(114, 4);
            this.ShapeBox.MaxDropDownItems = 5;
            this.ShapeBox.MaximumSize = new System.Drawing.Size(130, 0);
            this.ShapeBox.Name = "ShapeBox";
            this.ShapeBox.Size = new System.Drawing.Size(111, 30);
            this.ShapeBox.TabIndex = 0;
            this.ShapeBox.Text = "Line";
            this.ShapeBox.TextUpdate += new System.EventHandler(this.ShapeBoxChanged);
            this.ShapeBox.SelectedValueChanged += new System.EventHandler(this.ShapeBoxChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(680, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Print Drawing";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.Control;
            this.ClearButton.Enabled = false;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(20, 200);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(67, 29);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Visible = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButtonPress);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 562);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DrawSettingsPanel);
            this.Controls.Add(this.EnableDrawingButton);
            this.Controls.Add(this.ChooseDirectoryButton);
            this.Controls.Add(this.changeDirectoryButton);
            this.Controls.Add(this.characterCountLabel);
            this.Controls.Add(this.lineCountLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileNameField);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.editorBox);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TextEditor";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormResize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DrawSettingsPanel.ResumeLayout(false);
            this.DrawSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public RichTextBox editorBox;
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
        private Button ChooseDirectoryButton;
        private Button EnableDrawingButton;
        private Panel DrawSettingsPanel;
        private Label ThicknessLabel;
        private Label ColorLabel;
        private Label ShapeLabel;
        private ComboBox ThicknessBox;
        private ComboBox ColorBox;
        private ComboBox ShapeBox;
        private Label FilledLabel;
        private Button button1;
        private CheckBox FilledCheckBox;
        private Button ClearButton;
    }
}