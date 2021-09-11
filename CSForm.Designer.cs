namespace Notepad_
{
    partial class CSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSForm));
            this.Box = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Box.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:" +
    "]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.Box.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.Box.BackBrush = null;
            this.Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Box.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.Box.CharHeight = 14;
            this.Box.CharWidth = 8;
            this.Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Box.DisabledColor = System.Drawing.Color.Gray;
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.ForeColor = System.Drawing.Color.Black;
            this.Box.IsReplaceMode = false;
            this.Box.Language = FastColoredTextBoxNS.Language.CSharp;
            this.Box.LeftBracket = '(';
            this.Box.LeftBracket2 = '{';
            this.Box.LineNumberColor = System.Drawing.Color.Tomato;
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Paddings = new System.Windows.Forms.Padding(0);
            this.Box.RightBracket = ')';
            this.Box.RightBracket2 = '}';
            this.Box.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Box.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Box.ServiceColors")));
            this.Box.ServiceLinesColor = System.Drawing.Color.White;
            this.Box.Size = new System.Drawing.Size(800, 450);
            this.Box.TabIndex = 0;
            this.Box.Zoom = 100;
            this.Box.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.Box_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Box);
            this.Name = "CSForm";
            this.Text = "CSForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CSForm_FormClosing);
            this.TextChanged += new System.EventHandler(this.Box_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox Box;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}