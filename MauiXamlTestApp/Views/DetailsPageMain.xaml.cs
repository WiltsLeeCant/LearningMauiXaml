using MauiXamlTestApp.ViewModels;

namespace MauiXamlTestApp;

public partial class DetailsPageMain : ContentPage
{
	public DetailsPageMain(DetailsViewModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}