using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PenTweaker.App.ViewModels
{
    class PenInfoViewModel : INotifyPropertyChanged
    {
        private int _pressure = 0;

        public int Pressure {
            get { return _pressure;  }
            set {
                _pressure = value;
                OnPropertyChanged();
            }
        }

    #region plumbing
    public event PropertyChangedEventHandler PropertyChanged = delegate { };

    public void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        // Raise the PropertyChanged event, passing the name of the property whose value has changed.
        this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
}
}
