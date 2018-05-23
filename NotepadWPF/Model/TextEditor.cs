using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using NotepadWPF.ViewModel;
using System.Windows;

namespace NotepadWPF.Model
{
    class TextEditor
    {
        public TextEditor()
        {
           _BackgroundColor = Brushes.White;
           _FontColor = Brushes.Black;
        }

        private string _TextStock;
        public string TextStock
        {
            get { return _TextStock; }
            set
            {
                _TextStock = value;
            }
        }

        private SolidColorBrush _BackgroundColor;
        public SolidColorBrush BackgroundColor
        {
            get { return _BackgroundColor; }
            set
            {
                _BackgroundColor = value;
            }
        }

        private SolidColorBrush _FontColor;
        public SolidColorBrush FontColor
        {
            get { return _FontColor; }
            set
            {
                _FontColor = value;
            }
        }

        private string _FontFamily;
        public string FontFamily
        {
            get { return _FontFamily; }
            set
            {
                _FontFamily = value;
            }
        }

        private double _FontSize;
        public double FontSize
        {
            get { return _FontSize; }
            set
            {
                _FontSize = value;
            }
        }

        private System.Drawing.FontStyle _FontStyle;
        public System.Drawing.FontStyle FontStyle
        {
            get { return _FontStyle; }
            set
            {
                _FontStyle = value;
            }
        }
    }
}
