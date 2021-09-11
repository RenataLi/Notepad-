using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class DocForm : Form, IDocForm
    {
        // Variable for changing the text.
        public bool textChanged { get; set; }
        public string FileName { get; set; }
        public Color Colorr { get; set; }
       
        public DocForm()
        {
            InitializeComponent();
            Box.Multiline = true;
            Box.ContextMenuStrip = contextMenuStrip1;
        }
        /// <summary>
        /// Opening a file.
        /// </summary>
        /// <param name="filename"></param>
        public void OpenFile(string filename)
        {
            this.FileName = filename;
            this.Text = Path.GetFileName(filename);
            if (Path.GetExtension(filename) == ".txt")
                Box.Text = File.ReadAllText(filename);
            else
            {
                if (filename != null)
                {
                    if (Path.GetExtension(filename) == ".rtf" || Path.GetExtension(filename) == ".rtff")
                        Box.Rtf = File.ReadAllText(filename);
                    else
                        Box.Text = File.ReadAllText(filename);
                }

            }

        }
        /// <summary>
        /// Method for changing the text.
        /// </summary>
        /// <param name="text"></param>
        public void ChangeText(string text)
        {
            File.WriteAllText(FileName, "");
            File.WriteAllText(FileName, text);
            Box.Text = text;
        }
        /// <summary>
        /// Method to save as a file.
        /// </summary>
        public void SaveHowFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "rtf files (*.rtf)|*.rtf|txt files (*.txt)|*.txt|rtf files format(*.rtf)|*.rtff|code files (*.cs)|*.cs";
            saveFileDialog1.FilterIndex = 0;
           
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                SaveFile(filename);
            }
        }
        /// <summary>
        /// Method for saving the file.
        /// </summary>
        /// <param name="filename"></param>
        private void SaveFile(string filename)
        {
            if (this.FileName != null && File.Exists(FileName))
            {
                string directoryname;
                // In Properties.Settings.Default.filenames and Properties.Settings.Default.hashcodes file versions are stored.
                if (Properties.Settings.Default.filenames != null&& Properties.Settings.Default.filenames.Contains(FileName))
                {
                    for (int i = 0; i < Properties.Settings.Default.filenames.Count; i++)
                    {
                        if (Properties.Settings.Default.filenames[i] == this.FileName)
                        {
                            directoryname = Properties.Settings.Default.hashcodes[i];
                            File.Copy(this.FileName, Path.Combine(directoryname,
                            $"{Path.GetFileNameWithoutExtension(FileName)}.{DateTime.Now:yy.MM.dd.HH mm ss}{Path.GetExtension(FileName)}"));
                        }
                    }
                }
                else
                {
                    if (Properties.Settings.Default.filenames == null)
                    {

                        Properties.Settings.Default.filenames = new System.Collections.Specialized.StringCollection();
                        Properties.Settings.Default.hashcodes = new System.Collections.Specialized.StringCollection();
                    }
                    // Definition of the directory.
                    directoryname = Path.Combine(Environment.GetFolderPath
                        (Environment.SpecialFolder.LocalApplicationData),
                        Assembly.GetEntryAssembly().GetName().Name,
                        "backup", filename.ToUpper().GetHashCode().ToString());
                    if (!Directory.Exists(directoryname))
                    {
                        Directory.CreateDirectory(directoryname);
                    }
                    Properties.Settings.Default.filenames.Add(filename);
                    Properties.Settings.Default.hashcodes.Add(directoryname);
                    Properties.Settings.Default.Save();
                    // The format in which the file versions are stored.
                    File.Copy(this.FileName, Path.Combine(directoryname,
                        $"{Path.GetFileNameWithoutExtension(FileName)}.{DateTime.Now:yy.MM.dd.HH mm ss}{Path.GetExtension(FileName)}"));
                }

            }
            string extension = Path.GetExtension(filename);
            switch (extension)
            {
                case ".rtf":
                    Box.SaveFile(filename);
                    break;
                case ".rtff":
                    // RTF file with formatting.
                    File.WriteAllText(filename, null);
                    File.WriteAllText(filename, Box.Text);

                    break;
                case ".txt":
                    Box.SaveFile(filename, RichTextBoxStreamType.PlainText);
                    break;
                case ".cs":
                    File.WriteAllText(filename, null);
                    File.WriteAllText(filename, Box.Text);
                    break;
            }
            textChanged = false;
        }
        /// <summary>
        /// Saving file.
        /// </summary>
        public void SaveFile()
        {
            SaveFile(FileName);

        }
        /// <summary>
        /// The handler for changing the text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
        }
        /// <summary>
        /// Closing the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textChanged)
            {

                DialogResult result = MessageBox.Show(
                         "Сохранить изменения в файле?",
                                        $"{this.FileName}",
                              MessageBoxButtons.YesNoCancel,
                              MessageBoxIcon.Information,
                              MessageBoxDefaultButton.Button1,
                              MessageBoxOptions.DefaultDesktopOnly
                              );
                if (result == DialogResult.Yes)
                    SaveFile();
                else if (result == DialogResult.No)
                    return;
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;

            }
        }
        /// <summary>
        /// The choice of font.
        /// </summary>
        public void Font()
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Box.SelectionFont = fontDialog1.Font;
            }
        }
        /// <summary>
        /// Choice of color.
        /// </summary>
        /// <param name="c"></param>
        public void Color(Color c)
        {
            Box.BackColor = c;
            Colorr = c;
        }
        /// <summary>
        /// Undo the action.
        /// </summary>
        public void Cancel()
        {
            Box.Undo();
        }
        /// <summary>
        /// Redo the action.
        /// </summary>
        public void Return()
        {
            Box.Redo();
        }
        /// <summary>
        /// Copy text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Box.Copy();
        }
        /// <summary>
        /// Paste the text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PastetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Box.Paste();
        }
        /// <summary>
        /// Choose all text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseAlltoolStrip_Click(object sender, EventArgs e)
        {
            Box.SelectAll();
        }
        /// <summary>
        /// Font.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseFormattoolStrip_Click(object sender, EventArgs e)
        {
            Font();
        }
        /// <summary>
        /// Cut the text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CuttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Box.Cut();
        }
        public void AutoFormat() { }
       
    }
}
