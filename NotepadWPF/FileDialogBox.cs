using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using NotepadWPF.ViewModel;

namespace NotepadWPF
{
    public abstract class FileDialogBox : CommandDialogBox
    {
        public bool? FileDialogResult { get; protected set; }
        public string FilePath { get; set; }
        public string Filter { get; set; }
        public int FilterIndex { get; set; }
        public string DefaultExt { get; set; }

        protected Microsoft.Win32.FileDialog fileDialog = null;

        protected FileDialogBox()
        {
            execute =
                argument =>
                {
                    fileDialog.Title = Caption;
                    fileDialog.Filter = Filter;
                    fileDialog.FilterIndex = FilterIndex;
                    fileDialog.DefaultExt = DefaultExt;

                    string sciezkaPliku = "";
                    if (FilePath != null) sciezkaPliku = FilePath; else FilePath = "";
                    if (argument != null) sciezkaPliku = (string)argument;

                    if (!string.IsNullOrWhiteSpace(sciezkaPliku))
                    {
                        fileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(sciezkaPliku);
                        fileDialog.FileName = System.IO.Path.GetFileName(sciezkaPliku);
                    }

                    FileDialogResult = fileDialog.ShowDialog();
                    OnPropertyChanged("FileDialogResult");

                    if (FileDialogResult.HasValue && FileDialogResult.Value)
                    {
                        FilePath = fileDialog.FileName;
                        OnPropertyChanged("FilePath");
                        ExecuteCommand(CommandFileOK, CommandParameter);
                    };
                };
        }

        public static DependencyProperty CommandFileOKProperty =
            DependencyProperty.Register("CommandFileOK", typeof(ICommand), typeof(FileDialogBox));

        public ICommand CommandFileOK
        {
            get { return (ICommand)GetValue(CommandFileOKProperty); }
            set { SetValue(CommandFileOKProperty, value); }
        }
    }
}
