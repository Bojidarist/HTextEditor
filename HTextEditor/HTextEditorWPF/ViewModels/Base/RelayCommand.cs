using System;
using System.Windows.Input;

namespace HTextEditorWPF.ViewModels.Base
{
    class RelayCommand : ICommand
    {
        /// <summary>
        /// Command to be executed
        /// </summary>
        private Action commandAction;

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="action">Command</param>
        public RelayCommand(Action action)
        {
            this.commandAction = action;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Execute command
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            this.commandAction();
        }
        #endregion
    }
}
