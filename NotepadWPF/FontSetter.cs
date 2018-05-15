using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadWPF
{
    class FontSetter : FontDialogBox
    {
        public FontSetter()
        {
            fontDialog = new System.Windows.Forms.FontDialog();
        }
    }
}
