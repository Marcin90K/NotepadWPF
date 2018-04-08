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

namespace NotepadWPF
{
    class EditorFormat
    {
        public static void SetFont(object control)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                (control as System.Windows.Controls.RichTextBox).FontFamily = new System.Windows.Media.FontFamily(fontDialog.Font.Name);
                (control as System.Windows.Controls.RichTextBox).FontSize = fontDialog.Font.Size;
                (control as System.Windows.Controls.RichTextBox).FontStyle = fontDialog.Font.Italic ? FontStyles.Italic : FontStyles.Normal;
                (control as System.Windows.Controls.RichTextBox).FontWeight = fontDialog.Font.Bold ? FontWeights.Bold : FontWeights.Regular;
            }
        }

        public static void SetFontColor(object control)
        {
            ColorDialog colorDialog = new ColorDialog();
            SolidColorBrush syntaxFontColor = new SolidColorBrush();
            syntaxFontColor.Color = Colors.Blue;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {

                (control as System.Windows.Controls.RichTextBox).Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B));
            }

        }

        public static void SetBackgroundColor(object control)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                (control as System.Windows.Controls.RichTextBox).Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B));
            }
        }

    }
}
