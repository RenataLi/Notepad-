namespace Notepad_
{
    partial class Notepad
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
            this.components = new System.ComponentModel.Container();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpentoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveHowtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWintoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAlltoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClosetoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewtoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CanceltoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturntoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RollBacktoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FormattoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FonttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatCStoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColortoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColortoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PathtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFilestoolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CompiletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "Сохранить как";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem3.Text = "Открыть";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem,
            this.ChangetoolStripMenuItem,
            this.FormattoolStripMenuItem,
            this.SettingstoolStripMenuItem,
            this.OpenFilestoolStripMenu,
            this.CompiletoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.OpenFilestoolStripMenu;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1139, 35);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Файл";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpentoolStripMenuItem,
            this.SaveHowtoolStripMenuItem,
            this.SavetoolStripMenuItem,
            this.NewWintoolStripMenu,
            this.SaveAlltoolStripMenu,
            this.ClosetoolStripMenu,
            this.NewtoolStripMenu});
            this.toolStripMenuItem.MergeIndex = 0;
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.toolStripMenuItem.Text = "Файл";
            // 
            // OpentoolStripMenuItem
            // 
            this.OpentoolStripMenuItem.Name = "OpentoolStripMenuItem";
            this.OpentoolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.OpentoolStripMenuItem.Size = new System.Drawing.Size(423, 34);
            this.OpentoolStripMenuItem.Text = "Открыть";
            this.OpentoolStripMenuItem.Click += new System.EventHandler(this.Openfilebutton_Click);
            // 
            // SaveHowtoolStripMenuItem
            // 
            this.SaveHowtoolStripMenuItem.Name = "SaveHowtoolStripMenuItem";
            this.SaveHowtoolStripMenuItem.Size = new System.Drawing.Size(423, 34);
            this.SaveHowtoolStripMenuItem.Text = "Сохранить как";
            this.SaveHowtoolStripMenuItem.Click += new System.EventHandler(this.SaveFilebutton_Click);
            // 
            // SavetoolStripMenuItem
            // 
            this.SavetoolStripMenuItem.Name = "SavetoolStripMenuItem";
            this.SavetoolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.SavetoolStripMenuItem.Size = new System.Drawing.Size(423, 34);
            this.SavetoolStripMenuItem.Text = "Сохранить";
            this.SavetoolStripMenuItem.Click += new System.EventHandler(this.SavetoolStripMenuItem_Click);
            // 
            // NewWintoolStripMenu
            // 
            this.NewWintoolStripMenu.Name = "NewWintoolStripMenu";
            this.NewWintoolStripMenu.ShortcutKeyDisplayString = "Ctrl+Shift+N";
            this.NewWintoolStripMenu.Size = new System.Drawing.Size(423, 34);
            this.NewWintoolStripMenu.Text = "Создание в новом окне";
            this.NewWintoolStripMenu.Click += new System.EventHandler(this.NewWintoolStripMenu_Click);
            // 
            // SaveAlltoolStripMenu
            // 
            this.SaveAlltoolStripMenu.Name = "SaveAlltoolStripMenu";
            this.SaveAlltoolStripMenu.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.SaveAlltoolStripMenu.Size = new System.Drawing.Size(423, 34);
            this.SaveAlltoolStripMenu.Text = "Сохранить все вкладки";
            this.SaveAlltoolStripMenu.Click += new System.EventHandler(this.SaveAlltoolStripMenu_Click);
            // 
            // ClosetoolStripMenu
            // 
            this.ClosetoolStripMenu.Name = "ClosetoolStripMenu";
            this.ClosetoolStripMenu.ShortcutKeyDisplayString = "Ctrl+Shift+F";
            this.ClosetoolStripMenu.Size = new System.Drawing.Size(423, 34);
            this.ClosetoolStripMenu.Text = "Закрыть приложение";
            this.ClosetoolStripMenu.Click += new System.EventHandler(this.ClosetoolStripMenu_Click);
            // 
            // NewtoolStripMenu
            // 
            this.NewtoolStripMenu.Name = "NewtoolStripMenu";
            this.NewtoolStripMenu.ShortcutKeyDisplayString = "Ctrl+N";
            this.NewtoolStripMenu.Size = new System.Drawing.Size(423, 34);
            this.NewtoolStripMenu.Text = "Создание в новой вкладке";
            this.NewtoolStripMenu.Click += new System.EventHandler(this.NewtoolStripMenu_Click);
            // 
            // ChangetoolStripMenuItem
            // 
            this.ChangetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CanceltoolStripMenu,
            this.ReturntoolStripMenu,
            this.RollBacktoolStripMenu});
            this.ChangetoolStripMenuItem.Name = "ChangetoolStripMenuItem";
            this.ChangetoolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.ChangetoolStripMenuItem.Text = "Правка";
            // 
            // CanceltoolStripMenu
            // 
            this.CanceltoolStripMenu.Name = "CanceltoolStripMenu";
            this.CanceltoolStripMenu.ShortcutKeyDisplayString = "Ctrl+Z";
            this.CanceltoolStripMenu.Size = new System.Drawing.Size(288, 34);
            this.CanceltoolStripMenu.Text = "Отменить";
            this.CanceltoolStripMenu.Click += new System.EventHandler(this.CanceltoolStripMenu_Click);
            // 
            // ReturntoolStripMenu
            // 
            this.ReturntoolStripMenu.Name = "ReturntoolStripMenu";
            this.ReturntoolStripMenu.ShortcutKeyDisplayString = "Ctrl+Shift+Z";
            this.ReturntoolStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.ReturntoolStripMenu.Size = new System.Drawing.Size(288, 34);
            this.ReturntoolStripMenu.Text = "Вернуть";
            this.ReturntoolStripMenu.Click += new System.EventHandler(this.ReturntoolStripMenu_Click);
            // 
            // RollBacktoolStripMenu
            // 
            this.RollBacktoolStripMenu.Name = "RollBacktoolStripMenu";
            this.RollBacktoolStripMenu.Size = new System.Drawing.Size(288, 34);
            this.RollBacktoolStripMenu.Text = "Прошлые версии";
            this.RollBacktoolStripMenu.Click += new System.EventHandler(this.RollBacktoolStripMenu_Click);
            // 
            // FormattoolStripMenuItem
            // 
            this.FormattoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FonttoolStripMenuItem,
            this.FormatCStoolStripMenu});
            this.FormattoolStripMenuItem.Name = "FormattoolStripMenuItem";
            this.FormattoolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.FormattoolStripMenuItem.Text = "Формат";
            // 
            // FonttoolStripMenuItem
            // 
            this.FonttoolStripMenuItem.Name = "FonttoolStripMenuItem";
            this.FonttoolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.FonttoolStripMenuItem.Text = "Шрифт";
            this.FonttoolStripMenuItem.Click += new System.EventHandler(this.FonttoolStripMenuItem_Click);
            // 
            // FormatCStoolStripMenu
            // 
            this.FormatCStoolStripMenu.Name = "FormatCStoolStripMenu";
            this.FormatCStoolStripMenu.ShortcutKeyDisplayString = "";
            this.FormatCStoolStripMenu.Size = new System.Drawing.Size(280, 34);
            this.FormatCStoolStripMenu.Text = "Форматировать код";
            this.FormatCStoolStripMenu.Click += new System.EventHandler(this.FormatCStoolStripMenu_Click);
            // 
            // SettingstoolStripMenuItem
            // 
            this.SettingstoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimetoolStripMenuItem,
            this.ColortoolStripMenuItem,
            this.ColortoolStripMenuItem1,
            this.PathtoolStripMenuItem});
            this.SettingstoolStripMenuItem.MergeIndex = 10;
            this.SettingstoolStripMenuItem.Name = "SettingstoolStripMenuItem";
            this.SettingstoolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.SettingstoolStripMenuItem.Text = "Настройки";
            // 
            // TimetoolStripMenuItem
            // 
            this.TimetoolStripMenuItem.Name = "TimetoolStripMenuItem";
            this.TimetoolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.TimetoolStripMenuItem.Text = "Частота автосохранения";
            this.TimetoolStripMenuItem.Click += new System.EventHandler(this.TimetoolStripMenuItem_Click);
            // 
            // ColortoolStripMenuItem
            // 
            this.ColortoolStripMenuItem.Name = "ColortoolStripMenuItem";
            this.ColortoolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.ColortoolStripMenuItem.Text = "Цвет меню";
            this.ColortoolStripMenuItem.Click += new System.EventHandler(this.ColortoolStripMenuItem_Click);
            // 
            // ColortoolStripMenuItem1
            // 
            this.ColortoolStripMenuItem1.Name = "ColortoolStripMenuItem1";
            this.ColortoolStripMenuItem1.Size = new System.Drawing.Size(314, 34);
            this.ColortoolStripMenuItem1.Text = "Цвет фона текста";
            this.ColortoolStripMenuItem1.Click += new System.EventHandler(this.ColortoolStripMenuItem1_Click);
            // 
            // PathtoolStripMenuItem
            // 
            this.PathtoolStripMenuItem.Name = "PathtoolStripMenuItem";
            this.PathtoolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.PathtoolStripMenuItem.Text = "Путь к компилятору";
            this.PathtoolStripMenuItem.Click += new System.EventHandler(this.PathtoolStripMenuItem_Click);
            // 
            // OpenFilestoolStripMenu
            // 
            this.OpenFilestoolStripMenu.Name = "OpenFilestoolStripMenu";
            this.OpenFilestoolStripMenu.Size = new System.Drawing.Size(169, 29);
            this.OpenFilestoolStripMenu.Text = "Открытые файлы";
            // 
            // CompiletoolStripMenuItem
            // 
            this.CompiletoolStripMenuItem.Name = "CompiletoolStripMenuItem";
            this.CompiletoolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.CompiletoolStripMenuItem.Text = "Компилировать";
            this.CompiletoolStripMenuItem.Click += new System.EventHandler(this.CompiletoolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 647);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
            this.Load += new System.EventHandler(this.Notepad_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Notepad_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpentoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveHowtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormattoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFilestoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem SavetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FonttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColortoolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem NewWintoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveAlltoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ClosetoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem NewtoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ColortoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CanceltoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ReturntoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem RollBacktoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem FormatCStoolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem PathtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompiletoolStripMenuItem;
    }
}

