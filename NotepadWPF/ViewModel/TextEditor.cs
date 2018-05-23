using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Media;
using NotepadWPF.Model;
using System.Windows;

namespace NotepadWPF.ViewModel
{
    class TextEditor : INotifyPropertyChanged
    {
        Model.TextEditor model = null;

        public Commands Command { get; set; }

        public TextEditor()
        {
            model = new Model.TextEditor();
            Command = new Commands(this);
        }

        public string Text
        {
            get { return model.TextStock; }
            set
            {
                model.TextStock = value;
                OnPropertyChanged("Text");
            }
        }

        public SolidColorBrush BackgroundColor
        {
            get { return model.BackgroundColor; }
            set
            {
                model.BackgroundColor = value;
                OnPropertyChanged("BackgroundColor");
            }
        }

        public SolidColorBrush FontColor
        {
            get { return model.FontColor; }
            set
            {
                model.FontColor = value;
                OnPropertyChanged("FontColor");
            }
        }

        public string FontFamily
        {
            get { return model.FontFamily; }
            set
            {
                model.FontFamily = value;
                OnPropertyChanged("FontFamily");
            }
        }

        public double FontSize
        {
            get { return model.FontSize; }
            set
            {
                model.FontSize = value;
                OnPropertyChanged("FontSize");
            }
        }

        public System.Drawing.FontStyle FontStyle
        {
            get { return model.FontStyle; }
            set
            {
                model.FontStyle = value;
                OnPropertyChanged("FontStyle");
            }
        }

        public void OnPropertyChanged(string parameter)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(parameter));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
