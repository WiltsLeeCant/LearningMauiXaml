using MauiXamlTestApp.ViewModels;

namespace MauiXamlTestApp;

public partial class SearchPage : ContentPage
{
	public SearchPage(SearchPageModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}