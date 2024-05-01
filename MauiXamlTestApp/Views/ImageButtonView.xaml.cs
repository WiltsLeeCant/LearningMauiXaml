namespace MauiXamlTestApp;

public partial class ImageButtonView : ContentPage
{
    int clickTotal;

    public ImageButtonView()
	{
		InitializeComponent();
	}

    void OnImageButtonClicked(object sender, EventArgs e)
    {
        clickTotal += 1;
    }
}