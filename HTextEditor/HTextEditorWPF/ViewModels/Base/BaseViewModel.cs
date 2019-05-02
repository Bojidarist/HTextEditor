using System;
using System.Collections.Generic;
using System.Linq;
using PropertyChanged;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HTextEditorWPF.ViewModels.Base
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this to run a <see cref="PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
