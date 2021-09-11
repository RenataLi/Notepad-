using System.Drawing;

namespace Notepad_
{
    public interface IDocForm
    {
        /// <summary>
        /// This interface contains all the necessary methods for the two forms(CSForm and DocForm).
        /// </summary>
        // All methods are described in the appropriate forms.
        Color Colorr { get; set; }
        string FileName { get; set; }
      
        bool textChanged { get; set; }
        void AutoFormat();
        void Show();
        void Cancel();
        void ChangeText(string text);
        void Color(Color c);
        void Font();
        void OpenFile(string filename);
        void Return();
        void SaveFile();
        void SaveHowFile();
    }
}