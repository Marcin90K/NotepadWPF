using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Windows.Input;
using NotepadWPF.ViewModel;

namespace NotepadWPF
{
    public abstract class DialogBox : FrameworkElement, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string nazwaWlasciwosci)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nazwaWlasciwosci));

        }

        protected Action<object> execute = null;
        public string Caption { get; set; }
        protected ICommand _Show;
        public virtual ICommand Show
        {
            get
            {
                if (_Show == null)
                    _Show = new RelayCommand(execute);
                return _Show;
            }
        }
    }
}
