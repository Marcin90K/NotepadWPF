using NotepadWPF.ViewModel;
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
using System.Drawing;
using NotepadWPF.Model;
using System.ComponentModel;


namespace NotepadWPF.ViewModel
{
    class Commands 
    {

        public ViewModel.TextEditor textEditor { get; set; } 

        public Commands(ViewModel.TextEditor textEditorVM)
        {
            textEditor = textEditorVM;
        }


        private ICommand _NewFileCommand;
        public ICommand NewFileCommand
        {
            get
            {
                if (_NewFileCommand == null)
                {
                    _NewFileCommand = new RelayCommand(
                        argument =>
                        {
                            (argument as System.Windows.Controls.TextBox).Clear();
                            //DataIO.CurrentFileName = "";
                        }
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
                        argument =>
                            {
                                string path = (string)argument;
                                textEditor.Text = DataIO.OpenFile(path);
                            });
                }
                return _OpenFileCommand;
            }
        }


        private ICommand _SaveAsFileCommand;
        public ICommand SaveAsFileCommand
        {
            get
            {
                if (_SaveAsFileCommand == null)
                {
                    _SaveAsFileCommand = new RelayCommand(
                            argument =>
                                {
                                    string path = (string)argument;                                
                                    DataIO.SaveAsFile(path, textEditor.Text);
                                });
                }
                return _SaveAsFileCommand;
            }
        }

      /*  private ICommand _SaveFileCommand;
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
        }*/


        private ICommand _CloseAppCommand;
        public ICommand CloseAppCommand
        {
            get
            {
                if (_CloseAppCommand == null)
                {
                    _CloseAppCommand = new RelayCommand(
                        argument => { App.Current.MainWindow.Close(); }
                        //argument => true
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
                        argument => { App.Current.MainWindow.WindowState = System.Windows.WindowState.Minimized; }
                        );
                    else
                        _MaximizeAppCommand = new RelayCommand(
                        argument => { App.Current.MainWindow.WindowState = System.Windows.WindowState.Maximized; }
                        );
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
                        argument =>
                            {
                                Font font = (Font)argument;
                                textEditor.FontFamily = EditorFormat.SetFontFamily(font);
                                textEditor.FontSize = EditorFormat.SetFontSize(font);
                                textEditor.FontStyle = EditorFormat.SetFontStyle(font);
                            }
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
                        argument =>
                        {
                            SolidColorBrush solidColor = (SolidColorBrush)argument;
                            textEditor.FontColor = EditorFormat.SetFontColor(solidColor);
                        }
                        );
                return _FontColorCommand;
            }
        }

        private ICommand _BackgroundColorCommand;
        public ICommand BackgroundColorCommand
        {
            get
            {
                if (_BackgroundColorCommand == null)
                    _BackgroundColorCommand = new RelayCommand(
                        argument =>
                        {
                            SolidColorBrush solidColor = (SolidColorBrush)argument;
                            textEditor.BackgroundColor = EditorFormat.SetBackground(solidColor);
                        }
                        );
                return _BackgroundColorCommand;
            }
        }



        private ICommand _CallWebSide;
        public ICommand CallWebSide
        {
            get
            {
                if (_CallWebSide == null)
                {
                    _CallWebSide = new RelayCommand(
                        argument => HelpClass.CallingPage()
                        );
                }
                return _CallWebSide;
            }
        }
     }
}

