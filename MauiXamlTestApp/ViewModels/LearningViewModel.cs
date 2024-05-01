using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiXamlTestApp.DataModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiXamlTestApp.ViewModels
{
    public partial class LearningViewModel : ObservableObject
    {
        int counter = 0;
        private readonly IConnectivity _connectivity;
        private const string error = "Error", noInternet = "No internet access", ok = "OK";

        public bool IsRefresh { get; set; }
        public ICommand RefreshCommand => new Command(() =>
        {
            IsRefresh = true;
            Task.Delay(2000);
            RefreshItemProperties();
            IsRefresh = false;
        });

        public LearningViewModel(IConnectivity connectivity)
        {
            _connectivity = connectivity;
            RefreshItemProperties();
            ListItems = [];            
        }

        [ObservableProperty] ObservableCollection<string> listItems;
        [ObservableProperty] ObservableCollection<PeopleDataModel> refreshItems;
        [ObservableProperty] string? text;

        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrEmpty(Text))
            {
                return;
            }

            if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert(error, noInternet, ok);
            }

            ListItems.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        async Task Delete(string? item)
        {
            if (string.IsNullOrEmpty(item) || !ListItems.Contains(item))
            {
                return;
            }

            if(_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert(error, noInternet, ok);
            }

            ListItems.Remove(item);
        }

        [RelayCommand]
        async Task Tap(string? data)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailsPageMain)}?Text={data}");
        }

        private void RefreshItemProperties()
        {
            RefreshItems = [new() { Age = 1, Name = "A" }, new() { Age = 2, Name = "B" }, new() { Age = 3, Name = "C" }];

            counter++;
            RefreshItems.Add(new() {  Age = counter, Name = $"number: {counter}" });
        }
    }
}