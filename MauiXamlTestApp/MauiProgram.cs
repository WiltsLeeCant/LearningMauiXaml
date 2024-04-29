using MauiXamlTestApp.ViewModels;
using Microsoft.Extensions.Logging;

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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton(Connectivity.Current);

            builder.Services.AddTransient<DetailsPage>();
            builder.Services.AddTransient<DetailsViewModel>();
            builder.Services.AddTransient<LearningPage>();
            builder.Services.AddTransient<LearningViewModel>();
            builder.Services.AddTransient<SearchPage>();
            builder.Services.AddTransient<SearchPageModel>();

            return builder.Build();
        }
    }
}