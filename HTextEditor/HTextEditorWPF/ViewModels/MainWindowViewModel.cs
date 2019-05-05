using HTextEditorWPF.ViewModels.Base;
using System;
using System.Windows;
using System.Windows.Input;

namespace HTextEditorWPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Private properties
        private string _previewBrowserSource;
        private string _editorText;
        private string _windowTitleText = "Title";

        /// <summary>
        /// The current window
        /// </summary>
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
        public string PreviewBrowserSource
        {
            get { return _previewBrowserSource; }
            set { _previewBrowserSource = value; }
        }
        #endregion

        #region Commands
        /// <summary>
        /// A test command
        /// </summary>
        public ICommand TestMessageCommand { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="window">Set the current window</param>
        public MainWindowViewModel(Window window)
        {
            // Set the current window
            this.CurrentWindow = window;

            // Listen for StateChanged event
            this.CurrentWindow.StateChanged += CurrentWindow_StateChanged;

            // Initialize commands
            this.TestMessageCommand = new RelayCommand(() => MessageBox.Show("Test", "Test", MessageBoxButton.OK));
        }
        #endregion

        #region Events
        /// <summary>
        /// This event is called when the current window changes state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentWindow_StateChanged(object sender, EventArgs e)
        {
            // A message box for testing
            MessageBox.Show(this.CurrentWindow.WindowState.ToString());
        }
        #endregion
    }
}
