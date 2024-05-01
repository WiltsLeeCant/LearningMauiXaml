using MauiXamlTestApp.ViewModels;

namespace MauiXamlTestApp;

public partial class LearningPageMain : ContentPage
{
	public LearningPageMain(LearningViewModel model)
	{
		InitializeComponent();

        BindingContext = model;
	}
}