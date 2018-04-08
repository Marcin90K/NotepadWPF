using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace NotepadWPF
{
    class DataIO
    {
        private static string _CurrentFileName = "";

        public static string CurrentFileName
        {
            get { return _CurrentFileName; }
            set { _CurrentFileName = value; }
        }

        public static void OpenFile(object argument)
        {
            OpenFileDialog dialogOpen = new OpenFileDialog();
            dialogOpen.Title = "Open file...";
            dialogOpen.Filter = "Text files(*.txt)|*.txt |Document files(*.doc, *.docx)|*.doc;*.docx |All files(*.*)|*.*";
            if (dialogOpen.ShowDialog() == DialogResult.OK)  //(System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(dialogOpen.FileName, FileMode.Open))
                {
                    CurrentFileName = dialogOpen.FileName;
                    TextRange textRange = new TextRange((argument as System.Windows.Controls.RichTextBox).Document.ContentStart,
                                                         (argument as System.Windows.Controls.RichTextBox).Document.ContentEnd);
                    textRange.Load(fileStream, DataFormats.Text);
                }
            }   
        }

        public static void SaveAsFile(object argument)
        {
            SaveFileDialog dialogSave = new SaveFileDialog();
            dialogSave.Title = "Save file...";
            if (dialogSave.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(dialogSave.FileName, FileMode.Create))
                {
                    CurrentFileName = dialogSave.FileName;
                    TextRange textRange = new TextRange((argument as System.Windows.Controls.RichTextBox).Document.ContentStart,
                                                         (argument as System.Windows.Controls.RichTextBox).Document.ContentEnd);
                    textRange.Save(fileStream, DataFormats.Text);
                    
                }
                
            }
        }

        public static void SaveFile(object argument)
        {
            if (CurrentFileName != "")
            {
                using (FileStream fileStream = new FileStream(_CurrentFileName, FileMode.OpenOrCreate))
                {
                    TextRange textRange = new TextRange((argument as System.Windows.Controls.RichTextBox).Document.ContentStart,
                                                         (argument as System.Windows.Controls.RichTextBox).Document.ContentEnd);
                    textRange.Save(fileStream, DataFormats.Text);

                }
            }
            else
            {
                SaveAsFile(argument);
            }
                
        }
    }
}
