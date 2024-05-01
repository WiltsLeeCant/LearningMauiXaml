using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiXamlTestApp.ViewModels
{
    public class ClothViewModel
    {
        public bool IsRefresh { get; set; }
        public ObservableCollection<Cloth> Products { get; set; }
        public ICommand RefreshCommand => new Command(async () =>
        {
            IsRefresh = true;
            await Task.Delay(2000);
            RefreshItems();
            IsRefresh = false;
        });

        public ClothViewModel()
        {
            RefreshItems();
        }

        private void RefreshItems()
        {
            Products = [new Cloth() { IsOffer = true, Price = 32.0m, Title = "White T-shirt" }];
        }
    }

    public class Cloth 
    {
        public bool IsOffer { get; set; }
        public decimal Price { get; set; }
        public string? Title { get; set; }
    }
}