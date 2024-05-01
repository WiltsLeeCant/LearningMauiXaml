namespace MauiXamlTestApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(DetailsPageMain), typeof(DetailsPageMain));
            Routing.RegisterRoute(nameof(FlyoutFirstPage), typeof(FlyoutFirstPage));
            Routing.RegisterRoute(nameof(FlyoutPageMain), typeof(FlyoutPageMain));
            Routing.RegisterRoute(nameof(FlyoutSecondPageMain), typeof(FlyoutSecondPageMain));
            Routing.RegisterRoute(nameof(FlyoutSubPage), typeof(FlyoutSubPage));
            Routing.RegisterRoute(nameof(LearningPageMain), typeof(LearningPageMain));
            Routing.RegisterRoute(nameof(TabbedPageMain), typeof(TabbedPageMain));
            Routing.RegisterRoute(nameof(TestPageMain), typeof(TestPageMain));
            Routing.RegisterRoute(nameof(TestPage2Main), typeof(TestPage2Main));
            Routing.RegisterRoute(nameof(SearchPageMain), typeof(SearchPageMain));
        }
    }
}