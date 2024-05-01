using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiXamlTestApp.ViewModels
{
    public partial class TimePickerViewModel : ObservableObject
    {
        [ObservableProperty] TimeSpan selectedTime;

        public TimePickerViewModel()
        {
            SelectedTime = new TimeSpan(4, 30, 26);
        }
    }
}