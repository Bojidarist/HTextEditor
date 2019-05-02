using HTextEditorWPF.ViewModels.Base;
using System;
using System.Windows;

namespace HTextEditorWPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Private properties
        private string _previewBrowserSource;
        private string _editorText;
        private string _windowTitleText = "Title";
        private Window CurrentWindow { get; set; }
        #endregion

        #region Public properties
        /// <summary>
        /// The text in the current window's title bar
        /// </summary>
        public string WindowTitleText
        {
            get { return _windowTitleText; }
            set { _windowTitleText = value; }
        }

        /// <summary>
        /// The text in the editor window
        /// </summary>
        public string EditorText
        {
            get { return _editorText == string.Empty ? " " : _editorText; }
            set { _editorText = value; }
        }

        /// <summary>
        /// This is used to navigate the browser to specific page.
        /// </summary>
        public string PreviewBrowserSource { get { return _previewBrowserSource; }
            set { _previewBrowserSource = value; } }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="window">Set the current window</param>
        public MainWindowViewModel(Window window)
        {
            this.CurrentWindow = window;
        }
        #endregion

        #region Events
        /// <summary>
        /// This event is called when the current window changes state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentWindow_StateChanged(object sender,EventArgs e)
        {
            
        }
        #endregion
    }
}
