using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiXamlTestApp.ViewModels
{
    [QueryProperty("Text", "Text")]
    public partial class DetailsViewModel : ObservableObject
    {
        [ObservableProperty] string? text;

        [RelayCommand]
        async Task Return()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}