namespace Notepad_
{
    partial class DocForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Box = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PastetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseAlltoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CuttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseFormattoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(800, 450);
            this.Box.TabIndex = 1;
            this.Box.Text = "";
            this.Box.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopytoolStripMenuItem,
            this.PastetoolStripMenuItem,
            this.ChooseAlltoolStrip,
            this.CuttoolStripMenuItem,
            this.ChooseFormattoolStrip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 114);
            // 
            // CopytoolStripMenuItem
            // 
            this.CopytoolStripMenuItem.Name = "CopytoolStripMenuItem";
            this.CopytoolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.CopytoolStripMenuItem.Text = "Копировать";
            this.CopytoolStripMenuItem.Click += new System.EventHandler(this.CopytoolStripMenuItem_Click);
            // 
            // PastetoolStripMenuItem
            // 
            this.PastetoolStripMenuItem.Name = "PastetoolStripMenuItem";
            this.PastetoolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.PastetoolStripMenuItem.Text = "Вставить";
            this.PastetoolStripMenuItem.Click += new System.EventHandler(this.PastetoolStripMenuItem_Click);
            // 
            // ChooseAlltoolStrip
            // 
            this.ChooseAlltoolStrip.Name = "ChooseAlltoolStrip";
            this.ChooseAlltoolStrip.Size = new System.Drawing.Size(179, 22);
            this.ChooseAlltoolStrip.Text = "Выбрать весь текст";
            this.ChooseAlltoolStrip.Click += new System.EventHandler(this.ChooseAlltoolStrip_Click);
            // 
            // CuttoolStripMenuItem
            // 
            this.CuttoolStripMenuItem.Name = "CuttoolStripMenuItem";
            this.CuttoolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.CuttoolStripMenuItem.Text = "Вырезать";
            this.CuttoolStripMenuItem.Click += new System.EventHandler(this.CuttoolStripMenuItem_Click);
            // 
            // ChooseFormattoolStrip
            // 
            this.ChooseFormattoolStrip.Name = "ChooseFormattoolStrip";
            this.ChooseFormattoolStrip.Size = new System.Drawing.Size(179, 22);
            this.ChooseFormattoolStrip.Text = "Выбрать формат";
            this.ChooseFormattoolStrip.Click += new System.EventHandler(this.ChooseFormattoolStrip_Click);
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Box);
            this.Name = "DocForm";
            this.Text = "DocForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox Box;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CopytoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PastetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChooseAlltoolStrip;
        private System.Windows.Forms.ToolStripMenuItem CuttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChooseFormattoolStrip;
    }
}