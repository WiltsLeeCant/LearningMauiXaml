namespace MauiXamlTestApp.Views;

public partial class StepperViewMain : ContentPage
{
	public StepperViewMain()
	{
		InitializeComponent();
	}

    void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        _rotatingLabel.Rotation = value;
        _displayLabel.Text = string.Format("The Stepper value is {0}", value);
    }
}