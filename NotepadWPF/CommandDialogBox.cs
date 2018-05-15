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
    public abstract class CommandDialogBox : DialogBox
    {
        public override ICommand Show
        {
            get
            {
                if (_Show == null)
                    _Show = new RelayCommand(
                        argument =>
                        {
                            ExecuteCommand(CommandBefore, CommandParameter);
                            execute(argument);
                            ExecuteCommand(CommandAfter, CommandParameter);
                        }
                        );
                return _Show;
            }
        }

        public static DependencyProperty CommandParameterProperty =
            DependencyProperty.Register("CommandParameter", typeof(object), typeof(CommandDialogBox));

        public object CommandParameter
        {
            get { return GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        protected static void ExecuteCommand(ICommand command, object commandParameter)
        {
            if (command != null)
                if (command.CanExecute(commandParameter))
                    command.Execute(commandParameter);
        }

        public static DependencyProperty CommandBeforeProperty =
            DependencyProperty.Register("CommandBefore", typeof(ICommand), typeof(CommandDialogBox));

        public ICommand CommandBefore
        {
            get { return (ICommand)GetValue(CommandBeforeProperty); }
            set { SetValue(CommandBeforeProperty, value); }
        }

        public static DependencyProperty CommandAfterProperty =
            DependencyProperty.Register("CommandAfter", typeof(ICommand), typeof(CommandDialogBox));

        public ICommand CommandAfter
        {
            get { return (ICommand)GetValue(CommandAfterProperty); }
            set { SetValue(CommandAfterProperty, value); }
        }
    }
}
