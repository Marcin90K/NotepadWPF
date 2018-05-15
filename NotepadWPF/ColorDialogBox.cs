using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using NotepadWPF.ViewModel;

namespace NotepadWPF
{
    public abstract class ColorDialogBox : CommandDialogBox
    {
        public DialogResult? ColorDialogResult { get; protected set; }
        public SolidColorBrush Color { get; set; }

        protected ColorDialog colorDialog = null;
        

        protected ColorDialogBox()
        {
            execute =
            argument =>
            {
                //System.Drawing.Color solidColor;
               // Color color = colorDialog.Color;
                SolidColorBrush solidColor = null;
                if (Color != null) solidColor = new SolidColorBrush(System.Windows.Media.Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B)); else solidColor = null;
                if (argument != null) solidColor = (SolidColorBrush)argument;

                ColorDialogResult = colorDialog.ShowDialog();
                OnPropertyChanged("FileDialogResult");

                if (ColorDialogResult.HasValue && (ColorDialogResult.Value != null))
                {
                    Color = new SolidColorBrush(System.Windows.Media.Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B));
                    OnPropertyChanged("Color");
                    ExecuteCommand(CommandColorOK, CommandParameter);
                }
            };

        }

        public static DependencyProperty CommandColorOKProperty =
            DependencyProperty.Register("CommandColorOK", typeof(ICommand), typeof(ColorDialogBox));

        public ICommand CommandColorOK
        {
            get { return (ICommand)GetValue(CommandColorOKProperty); }
            set { SetValue(CommandColorOKProperty, value); }
        }
    }
    
}
