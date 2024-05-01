﻿using MauiXamlTestApp.ViewModels;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Foldable;

namespace MauiXamlTestApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseFoldable()
                .UseMauiMaps();

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton(Connectivity.Current);

            builder.Services.AddTransient<DetailsPageMain>();
            builder.Services.AddTransient<DetailsViewModel>();
            builder.Services.AddTransient<LearningPageMain>();
            builder.Services.AddTransient<LearningViewModel>();
            builder.Services.AddTransient<SearchPageMain>();
            builder.Services.AddTransient<SearchPageModel>();
            builder.Services.AddTransient<TimePickerViewMain>();
            builder.Services.AddTransient<TimePickerViewModel>();

            return builder.Build();
        }
    }
}