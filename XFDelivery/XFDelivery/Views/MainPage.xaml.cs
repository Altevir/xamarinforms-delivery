using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFDelivery.ViewModels;

namespace XFDelivery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(Navigation);
        }
    }
}