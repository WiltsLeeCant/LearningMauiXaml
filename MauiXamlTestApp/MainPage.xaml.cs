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
            await Shell.Current.GoToAsync(nameof(LearningPageMain));
        }

        private async void BtnTestPageNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TestPageMain));
        }

        private async void BtnTabbedPageMainNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TabbedPageMain));
        }

        private async void BtnSearchPageNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SearchPageMain));
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new TestPage2Main());
        }
    }
}