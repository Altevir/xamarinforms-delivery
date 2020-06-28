using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFDelivery.Models;
using XFDelivery.ViewModels;

namespace XFDelivery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Item item)
        {
            InitializeComponent();
            BindingContext = new DetailPageViewModel(Navigation, item);
        }
    }
}