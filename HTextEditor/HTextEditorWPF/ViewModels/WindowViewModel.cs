using HTextEditorWPF.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HTextEditorWPF.ViewModels
{
    public class WindowViewModel : BaseViewModel
    {
        #region Private properties
        private string _editorText = String.Empty;
        private string _windowTitleText = "Title";
        private Window CurrentWindow { get; set; }
        #endregion

        #region Public properties
        public string WindowTitleText
        {
            get { return _windowTitleText; }
            set
            {
                _windowTitleText = value;
                this.OnPropertyChanged(nameof(WindowTitleText));
            }
        }


        public string EditorText
        {
            get { return _editorText; }
            set { _editorText = value; this.OnPropertyChanged(nameof(EditorText)); }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="window">Set the current window</param>
        public WindowViewModel(Window window)
        {
            this.CurrentWindow = window;
        }
        #endregion

        #region Events
        private void CurrentWindow_StateChanged(object sender,EventArgs e)
        {

        }
        #endregion
    }
}
