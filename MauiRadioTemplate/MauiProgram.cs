namespace MauiRadioTemplate;

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
                fonts.AddFont("materialdesignicons-webfont.ttf", "IconFontTypes");
            });

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainVm>();
        return builder.Build();
    }
}