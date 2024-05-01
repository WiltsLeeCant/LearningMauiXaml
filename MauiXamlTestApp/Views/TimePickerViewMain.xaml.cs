using MauiXamlTestApp.ViewModels;

namespace MauiXamlTestApp;

public partial class TimePickerViewMain : ContentPage
{
    public TimePickerViewMain(TimePickerViewModel model)
	{
		InitializeComponent();

        BindingContext = model;
    }
}