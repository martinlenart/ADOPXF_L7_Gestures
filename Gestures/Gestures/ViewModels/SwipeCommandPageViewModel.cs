using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Gestures.ViewModels
{
    public class SwipeCommandPageViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion        
        public ICommand SwipeCommand => new Command<string>(OnSwipe);
        public string SwipeDirection { get; private set; }

        public SwipeCommandPageViewModel()
        {
            SwipeDirection = "You swiped: ";
        }

        void OnSwipe(string value)
        {
            SwipeDirection = $"You swiped: {value}";
            OnPropertyChanged("SwipeDirection");
        }
    }
}
