using MauiAbsoluteCollection.Pages;
using MauiAbsoluteCollection.ViewModels;

namespace MauiAbsoluteCollection;

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

        builder.Services.AddTransient<Page4>();
        builder.Services.AddTransient<Page5>();
        builder.Services.AddTransient<AbsoluteListVm>();

        return builder.Build();
	}
}
