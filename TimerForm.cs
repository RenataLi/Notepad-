using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class TimerForm : Form
    {
        /// <summary>
        /// This form opens when you select the autosave frequency.
        /// </summary>
        public int value = 1;
        /// <summary>
        /// The text is a hint for the user.
        /// </summary>
        public string Labeltext
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public TimerForm()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Select a save every minute.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            value = 60000;

            label1.Visible = true;
            label1.Text = "Каждую минуту";

        }
        /// <summary>
        /// Select a save every  5 minute.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            value = 300000;

            label1.Visible = true;
            label1.Text = "Каждые 5 минут";

        }
        /// <summary>
        /// Select a save every 2 minute.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            value = 120000;

            label1.Visible = true;
            label1.Text = "Каждые 2 минуты";

        }
        /// <summary>
        /// Select to not save.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            value = 0;
            label1.Visible = true;
            label1.Text = "Отключено";

        }


    }
}
