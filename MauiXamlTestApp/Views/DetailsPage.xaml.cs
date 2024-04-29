using MauiXamlTestApp.ViewModels;

namespace MauiXamlTestApp;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}