using MauiTabbedDI.Pages;

namespace MauiTabbedDI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(TabsPage), typeof(TabsPage));
        }
    }
}