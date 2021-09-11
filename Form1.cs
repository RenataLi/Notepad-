using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class Notepad : Form
    {
       

        public string timertext;
        /// <summary>
        /// Restore the settings from the config memory that were present when the program was last closed.
        /// </summary>
        public Notepad()
        {
            InitializeComponent();
            if (Properties.Settings.Default.openFiles != null)
            {
                foreach (var item in Properties.Settings.Default.openFiles)
                {
                    OpenFile(item);
                }

            }

            if (Properties.Settings.Default.color != null)
            {
                menuStrip1.BackColor = Properties.Settings.Default.color;

            }
            if (Properties.Settings.Default.color1 != null)
            {
                foreach (IDocForm item in this.MdiChildren)
                {

                    item.Color(Properties.Settings.Default.color1);
                }
            }

        }
        /// <summary>
        /// Handles opening of the file.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void Openfilebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Текстовые файлы|*.txt|RTF|*.rtf;*.rtff|Файлы кода|*.cs";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFile.FileName);

            }

        }
        /// <summary>
        /// Depending on the file type(code file or text file),opens the desired form.
        /// </summary>
        /// <param name="fileName">The file name(the full path of the file).</param>
        private void OpenFile(string fileName)
        {
            if (Path.GetExtension(fileName) == ".cs")
            {
                CSForm docForm = new CSForm();
                docForm.MdiParent = this;

                docForm.OpenFile(fileName);
                docForm.Show();
            }
            else
            {

                DocForm docForm = new DocForm();
                docForm.MdiParent = this;

                docForm.OpenFile(fileName);
                docForm.Show();
            }
        }
        /// <summary>
        /// Handles saving the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFilebutton_Click(object sender, EventArgs e)
        {
            IDocForm doc = this.ActiveMdiChild as IDocForm;
            if (doc == null)
                return;
            else
                doc.SaveHowFile();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /// <summary>
        /// Handles saving the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDocForm doc = this.ActiveMdiChild as IDocForm;
            if (doc == null)
                return;
            else
                doc.SaveFile();
        }
        /// <summary>
        /// Handles the font selection event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FonttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDocForm doc = this.ActiveMdiChild as IDocForm;
            if (doc == null)
                return;
            else
                doc.Font();
        }
        /// <summary>
        /// Select the menu color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColortoolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDocForm doc = this.ActiveMdiChild as IDocForm;
            if (doc == null)
                return;
            else
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    menuStrip1.BackColor = colorDialog1.Color;

                }

            }
        }
        /// <summary>
        /// Select a timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDocForm doc = this.ActiveMdiChild as IDocForm;
            if (doc == null)
                return;
            else
            {
                TimerForm timerForm = new TimerForm();
                // Check if the timer was already selected last time you opened the app.
                if (Properties.Settings.Default.timervalue != 1)
                {
                    timerForm.value = Properties.Settings.Default.timervalue;
                }
                if (Properties.Settings.Default.timertext != null)
                {
                    // If the timer value is not empty,then we resume it.
                    timerForm.Labeltext = Properties.Settings.Default.timertext;
                }
                timerForm.ShowDialog();
                timer1.Start();
                timer1.Interval = timerForm.value;
                Properties.Settings.Default.timervalue = timerForm.value;
                Properties.Settings.Default.timertext = timerForm.Labeltext;
                Properties.Settings.Default.Save();
                // Stop if the timer was not selected.
                if (timer1.Interval == 0)
                    timer1.Stop();

            }

        }
        /// <summary>
        /// At the end of the timer interval, we save each file in a loop.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (IDocForm item in this.MdiChildren)
                {
                    item.SaveFile();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Неизвестная ошибка!");
                return;

            }

        }
        /// <summary>
        /// Processing of hotkeys.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Notepad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.F)
            {

                ClosetoolStripMenu_Click(sender, e);
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.Z)
            {
                ReturntoolStripMenu_Click(sender, e);
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.N)
            {

                NewWintoolStripMenu_Click(sender, e);
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {

                SaveAlltoolStripMenu_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {

                Openfilebutton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {

                SaveFilebutton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {

                NewtoolStripMenu_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.Z)
            {
                CanceltoolStripMenu_Click(sender, e);
            }
        }
        /// <summary>
        /// Closing the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosetoolStripMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Processing saving all files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAlltoolStripMenu_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (IDocForm item in this.MdiChildren)
                {
                    if (item.FileName != null)
                    {

                        item.SaveFile();
                        item.textChanged = false;
                    }
                    else
                    {
                        // If the file was recently created and has not yet been saved, we suggest saving it as.
                        DialogResult result = MessageBox.Show(
                             "Данный файл еще не сохранен,Хотите сохранить как?",
                                            $"{item.FileName}",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Information,
                                  MessageBoxDefaultButton.Button1,
                                  MessageBoxOptions.DefaultDesktopOnly
                                  );
                        if (result == DialogResult.Yes)
                            item.SaveHowFile();
                        else if (result == DialogResult.No)
                            continue;

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Неизвестная ошибка");
                return;

            }

        }
        /// <summary>
        ///  New tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewtoolStripMenu_Click(object sender, EventArgs e)
        {
            DocForm d = new DocForm();
            d.MdiParent = this;
            d.Show();
        }
        /// <summary>
        /// New window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewWintoolStripMenu_Click(object sender, EventArgs e)
        {
            Notepad note = new Notepad();
            DocForm doc = new DocForm();
            doc.MdiParent = note;
            note.Show();
            doc.Show();
        }
        /// <summary>
        /// Event handler for closing the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.openFiles = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.color1 = new Color();

            foreach (IDocForm item in this.MdiChildren)
            {

                Properties.Settings.Default.openFiles.Add(item.FileName);
                Properties.Settings.Default.color1 = item.Colorr;
                Properties.Settings.Default.Save();
            }
            Properties.Settings.Default.color = new Color();
            Properties.Settings.Default.color = menuStrip1.BackColor;
            Properties.Settings.Default.Save();

        }
        /// <summary>
        /// The choice of color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColortoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IDocForm doc = this.ActiveMdiChild as IDocForm;
            if (doc == null)
                return;
            else
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (IDocForm item in this.MdiChildren)
                    {
                        item.Color(colorDialog1.Color);
                    }

                }

            }
        }
        /// <summary>
        /// Cancellation of the action.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CanceltoolStripMenu_Click(object sender, EventArgs e)
        {
            IDocForm doc = this.ActiveMdiChild as IDocForm;
            if (doc == null)
                return;
            else
                doc.Cancel();
        }
        /// <summary>
        /// Rerurn of the action.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturntoolStripMenu_Click(object sender, EventArgs e)
        {
            IDocForm doc = this.ActiveMdiChild as IDocForm;
            if (doc == null)
                return;
            else
                doc.Return();

        }
        /// <summary>
        /// Processes the output of past versions of the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollBacktoolStripMenu_Click(object sender, EventArgs e)
        {
            IDocForm doc = this.ActiveMdiChild as IDocForm;
            if (doc == null)
                return;
            else
            {
                if (doc.FileName != null)
                {

                    RollBack rollBack = new RollBack();
                    Log log = new Log(doc.FileName);
                    string directoryname = "";
                    System.Collections.Specialized.StringCollection str = Properties.Settings.Default.filenames;
                    // The versions of each file are stored in a folder with the corresponding hash code.
                    if (Properties.Settings.Default.filenames != null)
                    {
                        for (int i = 0; i < Properties.Settings.Default.filenames.Count; i++)
                        {
                            if (Properties.Settings.Default.filenames[i] == doc.FileName)
                            {
                                directoryname = Properties.Settings.Default.hashcodes[i];
                            }
                        }
                        // Hash codes and file names are stored in the user settings.
                        // The file versions are stored as Year, Month, Day, Hours, Minutes,and seconds.
                        if (log.GetFileVersions(doc.FileName, directoryname) != null)
                        {
                            rollBack.CreateItems(log.allfiles, Path.GetFileNameWithoutExtension(doc.FileName));
                            if (rollBack.ShowDialog() == DialogResult.OK)
                            {
                                if (rollBack.item != null)
                                {

                                    doc.ChangeText(File.ReadAllText(Path.Combine(directoryname, rollBack.item)));
                                    doc.Show();
                                }
                            }

                        }
                        else
                            return;

                    }


                }
                else
                {
                    MessageBox.Show("Файл еще не создан!");
                }
            }
        }
        /// <summary>
        /// Auto-formatting for code files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormatCStoolStripMenu_Click(object sender, EventArgs e)
        {
            IDocForm doc = this.ActiveMdiChild as IDocForm;
            if (doc == null)
                return;
            else
            {
                if (doc is CSForm)
                {
                    doc.AutoFormat();
                }
                else
                    return;

            }
        }
        /// <summary>
        /// Handles the compiler path selection event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PathtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Исполняемые файлы|*.exe";
                    openFileDialog.FileName = Properties.Settings.Default.Path;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.Path = openFileDialog.FileName;
                        Properties.Settings.Default.Save();
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Неизвестная ошибка!");
            }
        }
        /// <summary>
        /// Compiling the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompiletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                CSForm doc = this.ActiveMdiChild as CSForm;
                if (doc == null)
                    return;
                else
                {
                    if (string.IsNullOrEmpty(Properties.Settings.Default.Path))
                    {
                        PathtoolStripMenuItem_Click(sender, e);
                    }
                    if (!string.IsNullOrEmpty(Properties.Settings.Default.Path))
                    {
                        doc.Compile();
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Неизвестная ошибка!");
            }
        }

        private void Notepad_Load(object sender, EventArgs e)
        {

        }
    }
}
