namespace MauiXamlTestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnFlyoutPageMainNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(FlyoutPageMain));
        }

        private async void BtnLearningPageNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LearningPage));
        }

        private async void BtnTestPageNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TestPage));
        }

        private async void BtnTabbedPageMainNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TabbedPageMain));
        }

        private async void BtnSearchPageNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SearchPage));
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new TestPage2());
        }
    }
}