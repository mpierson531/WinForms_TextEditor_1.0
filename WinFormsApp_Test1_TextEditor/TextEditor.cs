using Microsoft.VisualBasic;
using System.Configuration;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WinFormsApp_Test1_TextEditor;

public partial class TextEditor : Form
{
    private JsonInfo InfoJson;
    private string SerializedJson;
    private string inputDirectory;
    private string defaultDirectory;
    private DirectoryInfo directoryInfo;
    private DirectoryInfo defaultDirectoryInfo;
    private JsonSerializerOptions OptionsForJson = new JsonSerializerOptions() { WriteIndented = true };
    public TextEditor()
    {
        InitializeComponent();
    }

    private void OpenMenuItem(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Title = "Choose A File To Open",
            InitialDirectory = InfoJson.DefaultDirectory
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            FileStream stream2 = File.OpenRead(openFileDialog.FileName);
            fileNameField.Text = openFileDialog.FileName;
            textAreaBox.Text = File.ReadAllText(openFileDialog.FileName);
            stream2.Close();
        }
    }

    private void SaveMenuItem(object sender, EventArgs e)
    {
        textAreaBox.SaveFile(fileNameField.Text, RichTextBoxStreamType.PlainText);
        textAreaBox.Text = "Saved " + fileNameField.Text;
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
                try
                {
                    var fileSave = File.CreateText(fileNameField.Text + ".txt");
                    fileSave.WriteLine(textAreaBox.Text);
                    fileSave.Close();
                    textAreaBox.Text = "Saved " + fileNameField.Text;
                }
                catch (Exception ex) { Interaction.MsgBox("File name field is empty. " + ex.Message); }
            }
            catch (DirectoryNotFoundException)
            { }
        }
    }

    private void OpenButton_Click(object sender, EventArgs e)
    {
        try
        {
            try
            {
                FileStream stream = File.OpenRead(fileNameField.Text);
                textAreaBox.Text = File.ReadAllText(fileNameField.Text);
                stream.Close();
            }
            catch (ArgumentException ae) { Interaction.MsgBox("File name field is empty. " + ae.Message); }
        }
        catch (FileNotFoundException)
        {
            Interaction.MsgBox("Could not find file");
        }
    }

    private void ExitItem_Click(object sender, EventArgs e)
    {
        if (sender == exitToolStripMenuItem)
        {
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
            InfoJson.InputDirectory = inputDirectory;
            SerializedJson = JsonSerializer.Serialize<JsonInfo>(InfoJson, OptionsForJson);
            File.WriteAllText(@InfoJson.DefaultDirectory + @"\config_file.json", SerializedJson);
            Directory.SetCurrentDirectory(@InfoJson.InputDirectory);
            //Properties.Settings.Default.InputDirectory = inputDirectory;
            //Properties.Settings.Default.Save();
        }
        catch (ArgumentException)
        {
            Interaction.MsgBox("Nothing Entered");
        }
    }

    private void lineCharacterCountFontToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FontDialogHelper();
    }

    private void mouseDrawingButton_Click(object sender, EventArgs e)
    {
        Pen pen1 = new Pen(Color.Red);
        Bitmap bitmap;
        textAreaBox.DrawToBitmap(bitmap = new Bitmap(5, 5), textAreaBox.Bounds);
        // Image image = Image.FromStream(textAreaB);
        Graphics graphics = textAreaBox.CreateGraphics();
        graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
        textAreaBox.Invalidate();
        graphics.DrawLine(pen1, MousePosition, MousePosition);

        // System.Drawing.Graphics.FromImage(textAreaBox.DrawToBitmap(bitmap = new Bitmap(5, 5), textAreaBox.Bounds););
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
            JsonNode jsonNode;
            directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            defaultDirectory = @directoryInfo.FullName + @"\Text Editor Files";
            defaultDirectoryInfo = new DirectoryInfo(@defaultDirectory.ToString());
            string jsonFilePath = @defaultDirectory + @"\config_file.json";

            InfoJson = new JsonInfo
            {
                DefaultDirectory = defaultDirectory,
                InputDirectory = string.Empty
            };

            if (!defaultDirectoryInfo.Exists)
            {
                Directory.CreateDirectory(defaultDirectory);
            }

            if ((!File.Exists(jsonFilePath)) || (File.ReadAllText(jsonFilePath) == null || File.ReadAllText(jsonFilePath) == ""))
            {
                var createConfigFile = File.CreateText(jsonFilePath);
                createConfigFile.Close();
                SerializedJson = JsonSerializer.Serialize<JsonInfo>(InfoJson, OptionsForJson);
                File.WriteAllText(@jsonFilePath, SerializedJson);
            }

            string jsonFromFile = File.ReadAllText(jsonFilePath);
            InfoJson = JsonSerializer.Deserialize<JsonInfo>(jsonFromFile);

            if (InfoJson.InputDirectory != null && InfoJson.InputDirectory != string.Empty)
            {
                Directory.SetCurrentDirectory(InfoJson.InputDirectory);
            }
            else if (InfoJson.InputDirectory == null || InfoJson.InputDirectory == string.Empty)
            {
                Directory.SetCurrentDirectory(InfoJson.DefaultDirectory);
            }


            /*else if (Properties.Settings.Default.DefaultDirectory != Properties.Settings.Default.InputDirectory)
            {
                inputDirectory = Properties.Settings.Default.InputDirectory;
                Directory.SetCurrentDirectory(inputDirectory);
            } else { Interaction.MsgBox("Lines 233 - 254: first and second if statements: not happening"); }*/
        }
        catch (Exception ex)
        {
            Interaction.MsgBox(ex.Message);
        }
    }

    private void WhenTheFormIsClosing(object sender, FormClosingEventArgs e)
    {
        /*defaultDirectory = Directory.GetCurrentDirectory();
        Properties.Settings.Default.DefaultDirectory = defaultDirectory;
        Properties.Settings.Default.Save();*/
    }
}