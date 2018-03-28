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
        public static void OpenFile(object argument)
        {
            OpenFileDialog dialogOpen = new OpenFileDialog();
            dialogOpen.Title = "Open file...";
            dialogOpen.Filter = "Text files(*.txt)|*.txt |Document files(*.doc, *.docx)|*.doc;*.docx |All files(*.*)|*.*";
            if (dialogOpen.ShowDialog() == DialogResult.OK)  //(System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(dialogOpen.FileName, FileMode.Open))
                {
                    TextRange textRange = new TextRange((argument as System.Windows.Controls.RichTextBox).Document.ContentStart,
                                                         (argument as System.Windows.Controls.RichTextBox).Document.ContentEnd);
                    textRange.Load(fileStream, DataFormats.Text);
                }
            }   
        }

        public static void SaveFile(object argument)
        {
            SaveFileDialog dialogSave = new SaveFileDialog();
            dialogSave.Title = "Save file...";
            //dialogSave.Filter = "Text files(*.txt)|*.txt |Document files(*.doc, *.docx)|*.doc;*.docx |All files(*.*)|*.*";
            if (dialogSave.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(dialogSave.FileName, FileMode.Create))
                {
                    TextRange textRange = new TextRange((argument as System.Windows.Controls.RichTextBox).Document.ContentStart,
                                                         (argument as System.Windows.Controls.RichTextBox).Document.ContentEnd);
                    textRange.Save(fileStream, DataFormats.Text);
                }
            }
        }
    }
}
