using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows;
using System.Drawing;
using System.Windows.Media;
using System.Windows.Documents;

namespace NotepadWPF.Model
{
    class EditorFormat
    {
        public static SolidColorBrush SetBackground(SolidColorBrush color)
        {
            SolidColorBrush solidColor = color;
            return solidColor;
        }

        public static SolidColorBrush SetFontColor(SolidColorBrush color)
        {
            SolidColorBrush solidColor = color;
            return solidColor;
        }

        public static string SetFontFamily(Font font)
        {
            string fontFamily = font.FontFamily.Name;
            return fontFamily;
        }

        public static System.Drawing.FontStyle SetFontStyle(Font font)
        {
            System.Drawing.FontStyle fontStyle = font.Style;
            return fontStyle;
        }

        public static double SetFontSize(Font font)
        {
            double fontSize = font.Size;
            return fontSize;
        }
    }
}
