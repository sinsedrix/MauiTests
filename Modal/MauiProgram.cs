using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Modal.Pages;
using Modal.ViewModels;

namespace Modal
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>(sp => new App { Container = sp })
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainVm>();

            Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
            builder.Services.AddSingleton<TestPage>();
            builder.Services.AddSingleton<TestVm>();

            Routing.RegisterRoute(nameof(ChoiceSelector), typeof(ChoiceSelector));
            builder.Services.AddSingleton<ChoiceSelector>();
            builder.Services.AddSingleton<ChoiceSelectorVm>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
