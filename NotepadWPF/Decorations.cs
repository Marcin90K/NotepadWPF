using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NotepadWPF
{
    class Decorations
    {
        private static Brush _Color;
        public static Brush Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public static void SetColor(object control)
        {
            Grid grid = control as Grid;

            Color = grid.Background;
        }
    }
}
