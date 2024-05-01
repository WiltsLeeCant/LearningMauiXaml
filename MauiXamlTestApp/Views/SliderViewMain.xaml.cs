namespace MauiXamlTestApp;

public partial class SliderViewMain : ContentPage
{
	public SliderViewMain()
	{
		InitializeComponent();
	}

    void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
    {
        double value = args.NewValue;
        rotatingLabel.Rotation = value;
        displayLabel.Text = String.Format("The Slider value is {0}", value);
    }
}