using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class RollBack : Form
    {
        /// <summary>
        /// This form opens when you select the file versions.
        /// </summary>
        // The selected item of combobox.
        public string item => (string)comboBox1.SelectedItem;
        public string[] files { get; set; }


        public RollBack()
        {
            InitializeComponent();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        /// <summary>
        /// Method for creating items.
        /// </summary>
        /// <param name="f"></param>
        /// <param name="name"></param>
        public void CreateItems(string[] f, string name)
        {
            for (int i = 0; i < f.Length; i++)
            {
                if (f[i].Contains(name))
                {

                   
                    comboBox1.Items.Add(Path.GetFileName(f[i]));
                }
            }
        }
        /// <summary>
        /// Method for creating items.
        /// </summary>
        /// <param name="filestoroll"></param>
        /// <param name="name"></param>
        public void CreateItems(StringCollection filestoroll, string name)
        {
            for (int i = 0; i < filestoroll.Count; i++)
            {
                if (filestoroll[i].Contains(name))
                {
                    files[i] = filestoroll[i];
                    comboBox1.Items.Add(Path.GetFileName(files[i]));
                }
            }

        }
    }
}
