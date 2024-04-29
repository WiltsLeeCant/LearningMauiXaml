﻿namespace MauiXamlTestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnTestPageNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TestPage));
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new TestPage2());
        }

        private async void BtnSearchPageNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SearchPage));
        }

        private async void BtnLearningPageNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LearningPage));
        }
    }
}