using MauiXamlTestApp.ViewModels;

namespace MauiXamlTestApp;

public partial class RefreshViewMain : ContentPage
{
    public RefreshViewMain(ClothViewModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}