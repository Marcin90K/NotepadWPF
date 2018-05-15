using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadWPF
{
    class ColorPicker : ColorDialogBox
    {
        public ColorPicker()
        {
            colorDialog = new System.Windows.Forms.ColorDialog();
        }
    }
}
