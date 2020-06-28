using System.Threading.Tasks;
using Xamarin.Forms;
using XFDelivery.Models;
using XFDelivery.ViewModel;

namespace XFDelivery.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        public DetailPageViewModel(INavigation navigation, Item item)
        {
            Navigation = navigation;
            PopDetailPageCommand = new Command(async () => await ExecutePopDetailPageCommand());
            AddQuantCommand = new Command(ExecuteAddQuantCommand);
            DeleteQuantCommand = new Command(ExecuteDeleteQuantCommand);
            Item = item;
            Quant = 1;
        }

        public Command PopDetailPageCommand { get; }
        public Command AddQuantCommand { get; }
        public Command DeleteQuantCommand { get; }
        public Item Item { get; set; }

        private int _quant;
        public int Quant
        {
            get { return _quant; }
            set { SetProperty(ref _quant, value); }
        }

        private async Task ExecutePopDetailPageCommand()
        {
            await Navigation.PopAsync();
        }

        private void ExecuteAddQuantCommand()
        {
            Quant += 1;
        }

        private void ExecuteDeleteQuantCommand()
        {
            if (Quant > 1)
                Quant -= 1;
        }
    }
}
