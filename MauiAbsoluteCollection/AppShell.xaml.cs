using MauiAbsoluteCollection.Pages;

namespace MauiAbsoluteCollection;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(Page4), typeof(Page4));
        Routing.RegisterRoute(nameof(Page5), typeof(Page5));
    }
}
