namespace MauiXamlTestApp;

public partial class ImageButtonViewMain : ContentPage
{
    int clickTotal;

    public ImageButtonViewMain()
	{
		InitializeComponent();
	}

    void OnImageButtonClicked(object sender, EventArgs e)
    {
        clickTotal += 1;
    }
}