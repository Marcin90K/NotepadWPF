using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadWPF
{
    class SaveFileDialogBox : FileDialogBox
    {
        public SaveFileDialogBox()
        {
            fileDialog = new Microsoft.Win32.SaveFileDialog();
        }
    }
}
