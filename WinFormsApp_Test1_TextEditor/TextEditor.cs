using Microsoft.VisualBasic;
using System.Configuration;

namespace WinFormsApp_Test1_TextEditor
{
    public partial class TextEditor : Form
    {
        private string inputDirectory;
        private string defaultDirectory;
        private DirectoryInfo directoryInfo;
        private DirectoryInfo defaultDirectoryInfo;
        //public static TextEditor __textEditor { get; private set; } = _textEditor;
        public TextEditor()
        {
            InitializeComponent();
        }

        private void OpenMenuItem(object sender, EventArgs e)
        {
            if (sender == openToolStripMenuItem)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Choose A File To Open",
                    InitialDirectory = inputDirectory
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream stream2 = File.OpenRead(openFileDialog.FileName);
                    fileNameField.Text = openFileDialog.FileName;
                    textAreaBox.Text = File.ReadAllText(openFileDialog.FileName);
                    stream2.Close();
                }
            }
        }

        private void SaveMenuItem(object sender, EventArgs e)
        {
            if (sender == saveToolStripMenuItem)
            {
                try
                {
                    Directory.SetCurrentDirectory(inputDirectory);
                    textAreaBox.SaveFile(fileNameField.Text, RichTextBoxStreamType.PlainText);
                    textAreaBox.Text = "Saved " + fileNameField.Text;
                }
                catch (DirectoryNotFoundException dnfe)
                {
                    textAreaBox.Text = "Directory not found";
                }
            }
        }

        private void SaveAsItem_Click(object sender, EventArgs e)
        {
            if (sender == saveAsToolStripMenuItem)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Save File As",
                    InitialDirectory = inputDirectory
                //InitialDirectory = Directory.GetCurrentDirectory()
            };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textAreaBox.SaveFile(fileNameField.Text, RichTextBoxStreamType.PlainText);
                    textAreaBox.Text = "Saved " + fileNameField.Text;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (sender == saveButton)
            {
                try
                {
                    Directory.SetCurrentDirectory(inputDirectory);
                    textAreaBox.SaveFile(fileNameField.Text, RichTextBoxStreamType.PlainText);
                    textAreaBox.Text = "Saved " + fileNameField.Text;
                }
                catch (DirectoryNotFoundException dnfe)
                {
                    textAreaBox.Text = "Directory not found";
                }
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (sender == openButton)
            {
                try
                {
                    Directory.SetCurrentDirectory(inputDirectory);
                    FileStream stream = File.OpenRead(fileNameField.Text);
                    textAreaBox.Text = File.ReadAllText(fileNameField.Text);
                    stream.Close();
                } catch (FileNotFoundException fnf) { textAreaBox.Text = "Could not find file"; }
            }
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            if (sender == exitToolStripMenuItem)
            {
                /*defaultDirectory = Directory.GetCurrentDirectory();
                Properties.Settings.Default.DefaultDirectory = defaultDirectory;*/
                //Properties.Settings.Default.Save();
                System.Environment.Exit(0);
            }
        }

        private void MainFontItem_Click(object sender, EventArgs e)
        {
            fontDialog1 = new FontDialog
            {
                ShowEffects = true,
                AllowScriptChange = true,
                ShowApply = true
            };
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textAreaBox.Font = fontDialog1.Font;
            }
            fontDialog1.Dispose();
        }

        private void NameFieldFontItem_Click(object sender, EventArgs e)
        {
            Font dialogFont;
            string messageBoxMessage = "Would you like to change both the file name input and the 'File Name:' label? Click 'No' to only change the name field";
            string messageBoxTitle = "Change File Name Field and/or Label";
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNoCancel;

            fontDialog1 = new FontDialog
            {
                ShowEffects = true,
                AllowScriptChange = true,
                ShowApply = true
            };
            if (MessageBox.Show(messageBoxMessage, messageBoxTitle, messageBoxButtons) == DialogResult.Yes)
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    dialogFont = fontDialog1.Font;
                    fileNameField.Font = dialogFont;
                    fileNameLabel.Font = dialogFont;
                }
            }
            else
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    dialogFont = fontDialog1.Font;
                    fileNameField.Font = dialogFont;
                }
            }
        }

        private void AllFontsItem_Click(object sender, EventArgs e)
        {
            Font dialogFont;
            fontDialog1 = new FontDialog
            {
                ShowEffects = true,
                AllowScriptChange = true,
                ShowApply = true
            };
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                dialogFont = fontDialog1.Font;

                textAreaBox.Font = dialogFont;
                fileNameLabel.Font = dialogFont;
                fileNameField.Font = dialogFont;
                openButton.Font = dialogFont;
                saveButton.Font = dialogFont;

                fileToolStripMenuItem.Font = dialogFont;
                settingsToolStripMenuItem.Font = dialogFont;

                changeDirectoryButton.Font = dialogFont;

                lineCountLabel.Font = dialogFont;
                characterCountLabel.Font = dialogFont;
            }
        }

        private void textAreaBox_TextChanged(object sender, EventArgs e)
        {
            lineCountLabel.Text = "Lines: " + textAreaBox.Lines.Length;
            characterCountLabel.Text = "Characters: " + textAreaBox.TextLength;
        }

        private void changeDirectoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                inputDirectory = Interaction.InputBox(@"Enter a directory", "Change Directory", "");
                Directory.SetCurrentDirectory(@inputDirectory);
                Properties.Settings.Default.InputDirectory = @inputDirectory;
                Properties.Settings.Default.Save();
            }
            catch (Exception ae)
            {
                textAreaBox.Text = ae.Source.ToString() + ": " + ae.InnerException + " " + ae.Message;
                if (ae is null)
                {
                    textAreaBox.Text = "Exception ae is null";
                }
            }
        }

        private void lineCharacterCountFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialogHelper();
        }

        public void FontDialogHelper()
        {
            Font fontFromDialog;
            FontDialog fontDialog;
            fontDialog = new FontDialog()
            {
                ShowEffects = true,
                ShowApply = true,
                ShowColor = true,
                AllowScriptChange = true,
            };

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fontFromDialog = fontDialog.Font;
                lineCountLabel.Font = fontFromDialog;
                characterCountLabel.Font = fontFromDialog;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                defaultDirectory = directoryInfo.FullName + @"\Text Editor Files";
                defaultDirectoryInfo = new DirectoryInfo(defaultDirectory.ToString());

                if (defaultDirectoryInfo.Exists == false)
                {
                    Directory.CreateDirectory(defaultDirectory);
                    Properties.Settings.Default.DefaultDirectory = defaultDirectory;
                    Properties.Settings.Default.InputDirectory = Properties.Settings.Default.DefaultDirectory;
                    Properties.Settings.Default.Save();
                    Directory.SetCurrentDirectory(defaultDirectory);
                    inputDirectory = Properties.Settings.Default.InputDirectory;
                }
                else if (Properties.Settings.Default.DefaultDirectory != Properties.Settings.Default.InputDirectory)
                {
                    inputDirectory = Properties.Settings.Default.InputDirectory;
                    Directory.SetCurrentDirectory(inputDirectory);
                }
            } catch (Exception ex)
            {
                textAreaBox.Text = ex.Message;
            }
        }

        private void WhenTheFormIsClosing(object sender, FormClosingEventArgs e)
        {
            /*defaultDirectory = Directory.GetCurrentDirectory();
            Properties.Settings.Default.DefaultDirectory = defaultDirectory;
            Properties.Settings.Default.Save();*/
        }
    }
}