namespace MauiXamlTestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            //MainPage = new NavigationPageMain(); // Page for navigation areas.
            //MainPage = new NavigationPage(new TestPage()); // Page for navigation areas programtically, changed by adding/removing from stack.
            //MainPage = new FlyoutPageMain(); // Flyout pages from the left.
            //MainPage = new TabbedPageMain(); // Tabs areas.

            //MainPage = new AbsoluteLayoutMain();
            //MainPage = new FlexLayoutMain();
            //MainPage = new GridLayoutMain();
            //MainPage = new StackLayoutMain();
            //MainPage = new H_V_StackLayout();
        }
    }
}