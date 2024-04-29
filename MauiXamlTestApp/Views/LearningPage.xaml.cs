using MauiXamlTestApp.ViewModels;

namespace MauiXamlTestApp;

public partial class LearningPage : ContentPage
{
	public LearningPage(LearningViewModel model)
	{
		InitializeComponent();

		BindingContext = model;
	}
}