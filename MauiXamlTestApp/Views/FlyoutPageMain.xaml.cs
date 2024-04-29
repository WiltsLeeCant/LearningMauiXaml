namespace MauiXamlTestApp;

public partial class FlyoutPageMain : FlyoutPage
{
	public FlyoutPageMain()
	{
        InitializeComponent();

        flyoutPageMain.btn.Clicked += OpenSecondPageClicked;
    }

    private void OpenSecondPageClicked(object? sender, EventArgs e)
    {
        if (!((IFlyoutPageController)this).ShouldShowSplitMode)
        {
            IsPresented = false;
        }
            
        Detail = new NavigationPage(new FlyoutSecondPage());
    }
}