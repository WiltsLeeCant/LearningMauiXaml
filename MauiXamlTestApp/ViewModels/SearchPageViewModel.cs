using CommunityToolkit.Mvvm.ComponentModel;


namespace MauiXamlTestApp.ViewModels
{
    public partial class SearchPageModel : ObservableObject
    {
        public SearchPageModel()
        {
            Label = "Test label";
            Title = typeof(SearchPageModel).Name;
        }

        [ObservableProperty]
        string _label, _title;
    }
}