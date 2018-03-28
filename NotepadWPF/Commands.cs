using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

namespace NotepadWPF
{
    class Commands
    {
        private ICommand _NewFileCommand;
        public ICommand NewFileCommand
        {
            get
            {
                if (_NewFileCommand == null)
                {
                    _NewFileCommand = new RelayCommand(
                        argument => { (argument as System.Windows.Controls.RichTextBox).Document.Blocks.Clear(); },
                        // argument =>  (argument as System.Windows.Controls.RichTextBox).Document != null
                        argument => true
                    );
                }
                return _NewFileCommand;
            }
        }


        private ICommand _OpenFileCommand;
        public ICommand OpenFileCommand
        {
            get
            {
                if (_OpenFileCommand == null)
                {
                    _OpenFileCommand = new RelayCommand(
                        argument => DataIO.OpenFile(argument),
                        argument => true);
                };
                return _OpenFileCommand;
            }
        }


        private ICommand _SaveFileCommand;
        public ICommand SaveFileCommand
        {
            get
            {
                if (_SaveFileCommand == null)
                {
                    _SaveFileCommand = new RelayCommand(
                        argument => DataIO.SaveFile(argument),
                        argument => true);
                }
                return _SaveFileCommand;
            }
        }


        private ICommand _CloseAppCommand;
        public ICommand CloseAppCommand
        {
            get
            {
                if (_CloseAppCommand == null)
                {
                    _CloseAppCommand = new RelayCommand(
                        argument => { App.Current.MainWindow.Close(); },
                        argument => true
                        );
                }
                return _CloseAppCommand;
            }
        }

        private ICommand _MaximizeAppCommand;
        public ICommand MaximizeAppCommand
        {
            get
            {
                if (_MaximizeAppCommand == null)
                {
                    if (App.Current.MainWindow.WindowState == System.Windows.WindowState.Maximized)
                        _MaximizeAppCommand = new RelayCommand(
                        argument => { App.Current.MainWindow.WindowState = System.Windows.WindowState.Minimized; },
                        argument => true
                        );
                    else
                        _MaximizeAppCommand = new RelayCommand(
                        argument => { App.Current.MainWindow.WindowState = System.Windows.WindowState.Maximized; },
                        argument => true
                        );

                   /* if (App.Current.MainWindow.WindowState == System.Windows.WindowState.Normal)
                        _MaximizeAppCommand = new RelayCommand(
                        argument => { App.Current.MainWindow.WindowState = System.Windows.WindowState.Minimized; },
                        argument => true
                        ); */
                  /*  else if (App.Current.MainWindow.WindowState == System.Windows.WindowState.Maximized)
                    {
                        _MaximizeAppCommand = new RelayCommand(
                       argument => { App.Current.MainWindow.WindowState = System.Windows.WindowState.Minimized; },
                       argument => true
                       );
                    } */
                }
                return _MaximizeAppCommand;
            }
        }

        private ICommand _FontSettingsCommand;
        public ICommand FontSettingsCommand
        {
            get
            {
                if (_FontSettingsCommand == null)
                {
                    _FontSettingsCommand = new RelayCommand(
                        argument => EditorFormat.SetFont(argument),
                        argument => true
                        );
                }
                return _FontSettingsCommand;
            }
        }

        private ICommand _FontColorCommand;
        public ICommand FontColorCommand
        {
            get
            {
                if (_FontColorCommand == null)
                    _FontColorCommand = new RelayCommand(
                        argument => EditorFormat.SetFontColor(argument),
                        argument => true
                            );
                return _FontColorCommand;
            }
        }

        private ICommand _SetBackground;
        public ICommand SetBackground
        {
            get
            {
                if (_SetBackground == null)
                {
                    _SetBackground = new RelayCommand(
                        argument => EditorFormat.SetBackgroundColor(argument),
                        argument => true
                        );
                }
                return _SetBackground;
            }
        }

       /* private  Brush _Color;
        public  Brush Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public void SetColor(object control)
        {
            Grid grid = control as Grid;

            Color = grid.Background;
        }

       /* private ICommand _CaretPositionCommand;
        public ICommand CaretPositionCommand
        {
           /* get
            {
                if (_CaretPositionCommand == null)
                    _CaretPositionCommand = new RelayCommand();
            }
        }*/

            /* public static void ClosingApp(object parameter)
             {
                 string text = new TextRange((parameter as System.Windows.Controls.RichTextBox).Document.ContentStart,
                                             (parameter as System.Windows.Controls.RichTextBox).Document.ContentEnd).Text;
                 if (text != null)
                 {
                     MessageBox.Show("The Notepad contains any text. Do you want to save it before closing?", "Closing...",
                                     MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                 }
                 else
                 {
                     App.Current.MainWindow.Close();
                 } 
                 App.Current.MainWindow.Close();
             } */

        }
}

