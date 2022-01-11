using Xamarin.Forms;

using Gestures.ViewModels;
namespace Gestures.Views
{
    public partial class SwipeCommandPage : ContentPage
    {
        public SwipeCommandPage()
        {
            InitializeComponent();
            BindingContext = new SwipeCommandPageViewModel();
        }
    }
}
