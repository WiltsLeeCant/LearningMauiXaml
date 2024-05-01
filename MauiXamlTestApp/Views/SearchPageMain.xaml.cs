using MauiXamlTestApp.ViewModels;

namespace MauiXamlTestApp;

public partial class SearchPageMain : ContentPage
{
	public SearchPageMain(SearchPageModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}