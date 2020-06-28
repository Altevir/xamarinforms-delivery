using Xamarin.Forms;
using XFDelivery.Interfaces;
using XFDelivery.Views;

namespace XFDelivery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new[] { "Shapes_Experimental" });

            MainPage = new NavigationPage(new MainPage());

            if (Device.RuntimePlatform == Device.Android)
                DependencyService.Get<IStatusBarStyle>().ChangeTextColor();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
