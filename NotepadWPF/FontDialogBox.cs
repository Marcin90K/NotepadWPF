using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using NotepadWPF.ViewModel;

namespace NotepadWPF
{
    public abstract class FontDialogBox : CommandDialogBox
    {
        public DialogResult? FontDialogResult { get; protected set; }
        public Font Font { get; set; }

        public System.Windows.Forms.FontDialog fontDialog = null;

        protected FontDialogBox()
        {
            execute =
                argument =>
                {
                    Font font = null;
                    if (font != null) font = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, fontDialog.Font.Style);
                    else font = null;

                    FontDialogResult = fontDialog.ShowDialog();
                    OnPropertyChanged("FontDialogResult");

                    if (FontDialogResult.HasValue && (FontDialogResult.Value != null))
                    {
                        Font = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size, fontDialog.Font.Style);
                        OnPropertyChanged("Font");
                        ExecuteCommand(CommandFontOK, CommandParameter);
                    }

                };
        }

        public static DependencyProperty CommandFontOKProperty =
        DependencyProperty.Register("CommandFontOK", typeof(ICommand), typeof(FontDialogBox));

        public ICommand CommandFontOK
        {
            get { return (ICommand)GetValue(CommandFontOKProperty); }
            set { SetValue(CommandFontOKProperty, value); }
        }
    }
}
