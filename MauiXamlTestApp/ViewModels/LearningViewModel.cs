using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiXamlTestApp.ViewModels
{
    public partial class LearningViewModel : ObservableObject
    {
        private readonly IConnectivity _connectivity;
        private const string error = "Error", noInternet = "No internet access", ok = "OK";

        public LearningViewModel(IConnectivity connectivity)
        {
            _connectivity = connectivity;
            Items = [];
        }

        [ObservableProperty] ObservableCollection<string> items;
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

            Items.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        async Task Delete(string? item)
        {
            if (string.IsNullOrEmpty(item) || !Items.Contains(item))
            {
                return;
            }

            if(_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert(error, noInternet, ok);
            }

            Items.Remove(item);
        }

        [RelayCommand]
        async Task Tap(string? data)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}?Text={data}");
        }
    }
}