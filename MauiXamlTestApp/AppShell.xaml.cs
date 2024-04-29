namespace MauiXamlTestApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
            Routing.RegisterRoute(nameof(LearningPage), typeof(LearningPage));
            Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
            Routing.RegisterRoute(nameof(TestPage2), typeof(TestPage2));
            Routing.RegisterRoute(nameof(SearchPage), typeof(SearchPage));
        }
    }
}