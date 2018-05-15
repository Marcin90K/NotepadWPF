using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NotepadWPF.ViewModel
{
    class RelayCommand : ICommand
    {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            if (execute == null) throw new ArgumentNullException("execute");
            _Execute = execute;
            _CanExecute = canExecute;
        }

        public RelayCommand(Action<object> execute)
        {
            if (execute == null) throw new ArgumentNullException("execute");
            _Execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return _CanExecute == null ? true : _CanExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_CanExecute != null) CommandManager.RequerySuggested += value;
            }
            remove
            {
                if (_CanExecute != null) CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            _Execute(parameter);
        }
    }
}
