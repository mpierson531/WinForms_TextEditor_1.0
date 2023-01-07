using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp_Test1_TextEditor
{
    public partial class TextEditor : Form
    {
        private readonly IStorageService _storage;
        private JsonInfo Json;
        private string SerializedJson;
        private string inputDirectory;
        private string defaultDirectory;
        private DirectoryInfo directoryInfo;
        private DirectoryInfo defaultDirectoryInfo;
        private readonly JsonSerializerOptions OptionsForJson;
        private Text_Editor.DrawingPanel DrawingPanel;

        public TextEditor(LocalStorageService service)
        {
            InitializeComponent();
            _storage = service;
            Json = new JsonInfo();
            OptionsForJson = new JsonSerializerOptions() { WriteIndented = true };
            DrawingPanel = new Text_Editor.DrawingPanel(editorBox.Location, editorBox.Size);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                defaultDirectory = @directoryInfo.FullName + @"\Text Editor Files";
                defaultDirectoryInfo = new DirectoryInfo(@defaultDirectory);
                string jsonFilePath = @defaultDirectory + @"\config_file.json";

                Json = new JsonInfo
                {
                    DefaultDirectory = defaultDirectory,
                    InputDirectory = string.Empty
                };

                if (!defaultDirectoryInfo.Exists)
                {
                    Directory.CreateDirectory(defaultDirectory);
                }

                if ((!File.Exists(jsonFilePath)) || (_storage.ReadFile(jsonFilePath) == null || _storage.ReadFile(jsonFilePath) == ""))
                {
                    using (var createConfigFile = _storage.CreateFile(jsonFilePath))
                    {
                        createConfigFile.Close();
                    }

                    SerializedJson = Json.Serialize(OptionsForJson);
                    _storage.WriteFile(jsonFilePath, SerializedJson);
                }

                string jsonFromFile = _storage.ReadFile(jsonFilePath);
                Json = Json.Deserialize(jsonFromFile);

                if (Json.InputDirectory != null && Json.InputDirectory != string.Empty && Directory.Exists(Json.InputDirectory))
                {
                    Directory.SetCurrentDirectory(Json.InputDirectory);
                }
                else
                {
                    Directory.SetCurrentDirectory(Json.DefaultDirectory);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }

            DrawSettingsPanel.Location = new Point(DrawSettingsPanel.Location.X - 7, DrawSettingsPanel.Location.Y + 4);
            ClearButton.Location = new Point(DrawSettingsPanel.Location.X, ClearButton.Location.Y);
            this.Controls.Add(DrawingPanel);
        }

        private void OpenMenuItem(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = "Choose File",
                InitialDirectory = Directory.GetCurrentDirectory()
            };

            var openDialogResult = openFileDialog.ShowDialog();

            string dialogFileName = openFileDialog.FileName.Trim();

            if (openDialogResult == DialogResult.OK && dialogFileName.Contains(@"\\"))
            {
                Interaction.MsgBox("Filename contained too many slashes.");
            }
            else if (openDialogResult == DialogResult.OK && dialogFileName.Contains('.'))
            {
                editorBox.Text = _storage.ReadFile(dialogFileName);
            }
            else if (openDialogResult == DialogResult.OK && dialogFileName is not null or "" or " ")
            {
                editorBox.Text = _storage.ReadFile(dialogFileName + ".txt");
            }
            else if (openDialogResult != DialogResult.Cancel)
            {
                Interaction.MsgBox("Filename was empty.");
            }

            openFileDialog.Dispose();
        }

        private void SaveMenuItem(object sender, EventArgs e)
        {
            string fileName = fileNameField.Text.Trim();

            try
            {
                if (fileName.Contains(@"\\"))
                {
                    Interaction.MsgBox("Filename contained too many slashes.");
                }
                else if (fileName.Contains('.'))
                {
                    _storage.WriteFile(fileName, editorBox.Text);
                    editorBox.Text = "Saved " + fileName;
                }
                else if (fileName != null && fileName is not null or "" or " ")
                {
                    _storage.WriteFile($"{fileName}.txt", editorBox.Text);
                    editorBox.Text = $"Saved {fileName}.txt";
                }
                else
                {
                    Interaction.MsgBox("Filename was null");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void SaveAsItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Title = "Save File As",
                InitialDirectory = Directory.GetCurrentDirectory()
            };

            var saveAsDialogResult = saveFileDialog.ShowDialog();

            string dialogFileName = saveFileDialog.FileName.Trim();

            if (saveAsDialogResult == DialogResult.OK && dialogFileName.Contains(@"\\"))
            {
                Interaction.MsgBox("Filename contained too many slashes.");
            }
            if (saveAsDialogResult == DialogResult.OK && dialogFileName.Contains('.'))
            {
                _storage.WriteFile($"{dialogFileName}", editorBox.Text);
                editorBox.Text = "Saved " + dialogFileName;
            }
            else if (saveAsDialogResult == DialogResult.OK && dialogFileName is not null or "" or " ")
            {
                _storage.WriteFile($"{dialogFileName}.txt", editorBox.Text);
                editorBox.Text = $"Saved {dialogFileName}.txt";
            }
            else if (saveAsDialogResult != DialogResult.Cancel)
            {
                Interaction.MsgBox("Filename was null");
            }

            saveFileDialog.Dispose();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string fileName = fileNameField.Text.Trim();

            try
            {
                if (!DrawingPanel.DrawingEnabled)
                {
                    if (fileName.Contains(@"\\"))
                    {
                        Interaction.MsgBox("Filename contained too many slashes.");
                    }
                    else if (fileName.Contains('.'))
                    {
                        _storage.WriteFile(fileName, editorBox.Text);
                        editorBox.Text = "Saved " + fileName;
                    }
                    else if (fileName is not null or "" or " ")
                    {
                        _storage.WriteFile($"{fileName}.txt", editorBox.Text);
                        editorBox.Text = $"Saved {fileName}.txt";
                    }
                    else
                    {
                        Interaction.MsgBox("Filename was null");
                    }
                }
                else
                {
                    if (fileName.Contains(@"\\"))
                    {
                        Interaction.MsgBox("Filename contained too many slashes.");
                    }
                    else if (fileName.Contains('.'))
                    {
                        DrawingPanel.DrawingBitmap.Save(fileName);
                        Interaction.MsgBox($"Saved {fileName}.");
                    }
                    else if (fileName is not null or "" or " " && DrawingPanel.DrawingBitmap != null)
                    {
                        DrawingPanel.DrawingBitmap.Save($"{fileName}.png", ImageFormat.Png);
                        Interaction.MsgBox($"Saved {fileName}.png.");
                    }
                    else
                    {
                        Interaction.MsgBox("Filename was null");
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            string fileName = fileNameField.Text.Trim();

            try
            {
                if (fileName.Contains(@"\\"))
                {
                    Interaction.MsgBox("Filename contained too many slashes.");
                }
                else if (fileName.Contains('.'))
                {
                    editorBox.Text = _storage.ReadFile(fileName);
                }
                else if (fileName is not null or "" or " ")
                {
                    editorBox.Text = _storage.ReadFile($"{fileName}.txt");
                }
                else
                {
                    Interaction.MsgBox("File doesn't exist.");
                }
            }
            catch (FileNotFoundException ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            bool configFileExists = File.Exists($"{Json.DefaultDirectory}\\configFile.json");

            if (configFileExists)
            {
                string serializedJson = Json.Serialize(OptionsForJson);
                _storage.WriteFile(Json.DefaultDirectory + "\\config_file.json", serializedJson);
            }

            Environment.Exit(0);
        }

        private void MainFontItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = GetFontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Color dialogColor = fontDialog.Color;
                editorBox.Font = fontDialog.Font;
                editorBox.ForeColor = dialogColor;
            }

            fontDialog.Dispose();
        }

        private void NameFieldFontItem_Click(object sender, EventArgs e)
        {
            string messageBoxMessage = "Would you like to change both the file name input and the 'File Name:' label? Click 'No' to only change the name field";
            string messageBoxTitle = "Change File Name Field and/or Label";
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNoCancel;

            FontDialog fontDialog = GetFontDialog();

            switch (MessageBox.Show(messageBoxMessage, messageBoxTitle, messageBoxButtons), fontDialog.ShowDialog())
            {
                case (DialogResult.Yes, DialogResult.OK):
                    Color dialogColor = fontDialog.Color;
                    Font dialogFont = fontDialog.Font;

                    fileNameField.Font = dialogFont;
                    fileNameLabel.Font = dialogFont;
                    fileNameField.ForeColor = dialogColor;
                    fileNameLabel.ForeColor = dialogColor;
                    break;

                case (DialogResult.No, DialogResult.OK):
                    dialogFont = fontDialog.Font;
                    dialogColor = fontDialog.Color;
                    fileNameField.Font = dialogFont;
                    fileNameField.ForeColor = dialogColor;
                    break;
            };

            fontDialog.Dispose();
        }

        private void AllFontsItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = GetFontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font dialogFont = fontDialog.Font;
                Color dialogColor = fontDialog.Color;

                editorBox.Font = dialogFont;
                fileNameField.Font = dialogFont;
                editorBox.ForeColor = dialogColor;
                fileNameField.ForeColor = dialogColor;

                openButton.Font = dialogFont;
                saveButton.Font = dialogFont;
                changeDirectoryButton.Font = dialogFont;
                openButton.ForeColor = dialogColor;
                saveButton.ForeColor = dialogColor;
                changeDirectoryButton.ForeColor = dialogColor;

                fileToolStripMenuItem.Font = dialogFont;
                settingsToolStripMenuItem.Font = dialogFont;
                fileToolStripMenuItem.ForeColor = dialogColor;
                settingsToolStripMenuItem.ForeColor = dialogColor;

                fileNameLabel.Font = dialogFont;
                lineCountLabel.Font = dialogFont;
                characterCountLabel.Font = dialogFont;
                fileNameLabel.ForeColor = dialogColor;
                lineCountLabel.ForeColor = dialogColor;
                characterCountLabel.ForeColor = dialogColor;
            }

            fontDialog.Dispose();
        }

        private void textAreaBox_TextChanged(object sender, EventArgs e)
        {
            lineCountLabel.Text = "Lines: " + editorBox.Lines.Length;
            characterCountLabel.Text = "Characters: " + editorBox.TextLength;
        }

        private void changeDirectoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                inputDirectory = Interaction.InputBox(@"Enter a directory", "Change Directory", "").Trim();
                if (Directory.Exists(inputDirectory))
                {
                    Json.InputDirectory = inputDirectory;
                    SerializedJson = Json.Serialize(OptionsForJson);
                    _storage.WriteFile(Json.DefaultDirectory + @"\config_file.json", SerializedJson);
                    Directory.SetCurrentDirectory(Json.InputDirectory);
                }
                else if (inputDirectory.Contains('.'))
                {
                    Interaction.MsgBox("Input directory not valid. It contained a '.'");
                }
                else if (inputDirectory.Contains(@"\\"))
                {
                    Interaction.MsgBox("Input directory not valid. It contained at least one double slash.");
                }
            }
            catch (ArgumentException)
            {
                Interaction.MsgBox("Nothing Entered");
            }
        }

        private void lineCharacterCountFontMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = GetFontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font fontFromDialog = fontDialog.Font;
                Color dialogColor = fontDialog.Color;
                lineCountLabel.Font = fontFromDialog;
                characterCountLabel.Font = fontFromDialog;
                lineCountLabel.ForeColor = dialogColor;
                characterCountLabel.ForeColor = dialogColor;
            }
        }

        private void ChooseDirectoryButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true
            };

            var dialogResult = folderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK && Directory.Exists(folderDialog.SelectedPath))
            {
                string path = folderDialog.SelectedPath.Trim();
                Json.InputDirectory = path;
                Directory.SetCurrentDirectory(path);
            }
        }

        public FontDialog GetFontDialog()
        {
            return new FontDialog()
            {
                ShowEffects = true,
                ShowColor = true,
                AllowScriptChange = true,
            };
        }

        private void ActivateDrawingClick(object sender, EventArgs e)
        {
            if (DrawingPanel.DrawingEnabled)
            {
                DrawingPanel.DrawingEnabled = false;
                DrawingPanel.Visible = false;
                DrawingPanel.Enabled = false;
                DrawingPanel.DrawingBitmap = null;

                ClearButton.Visible = false;
                ClearButton.Enabled = false;

                DrawSettingsPanel.Visible = false;
                DrawSettingsPanel.Enabled = false;

                editorBox.Visible = true;
                editorBox.Enabled = true;

                EnableDrawingButton.Text = "Enable Drawing";
                return;
            }

            ActivateDrawingPanel(new Bitmap(editorBox.Width, editorBox.Height));

            ClearButton.Visible = true;
            ClearButton.Enabled = true;

            editorBox.Visible = false;
            editorBox.Enabled = false;

            EnableDrawingButton.Text = "Disable Drawing";

            DrawSettingsPanel.Visible = true;
            DrawSettingsPanel.Enabled = true;
        }

        private void ShapeBoxChanged(object sender, EventArgs e)
        {
            DrawingPanel.DrawShapeType = ShapeBox.Text;
        }

        private void ColorBoxChanged(object sender, EventArgs e)
        {
            DrawingPanel.DrawColor = ColorBox.Text;
        }

        private void ThicknessBoxChanged(object sender, EventArgs e)
        {
            DrawingPanel.DrawThickness = ThicknessBox.Text;
        }

        private void FilledCheckBoxChanged(object sender, EventArgs e)
        {
            DrawingPanel.Filled = FilledCheckBox.Checked;
        }

        private void ClearButtonPress(object sender, EventArgs e)
        {
            DrawingPanel.Clear(Color.White);
        }

        private void FormResize(object sender, EventArgs e)
        {
            if (DrawingPanel.DrawingEnabled)
            {
                DrawingPanel.ResizePanel(Size.Width, Size.Height);
            }
        }

        private void ActivateDrawingPanel(Bitmap bitmap)
        {
            DrawingPanel.DrawShapeType = ShapeBox.Text;
            DrawingPanel.Filled = FilledCheckBox.Checked;
            DrawingPanel.DrawColor = ColorBox.Text;
            DrawingPanel.DrawThickness = ThicknessBox.Text;
            DrawingPanel.DrawingBitmap = bitmap;
            DrawingPanel.DrawingEnabled = true;
            DrawingPanel.Visible = true;
            DrawingPanel.Enabled = true;
            DrawingPanel.Invalidate();
        }
    }
}