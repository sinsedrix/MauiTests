using MauiTabbedDI.ViewModels;

namespace MauiTabbedDI.Pages
{
    public partial class TabsPage : TabbedPage
    {
        TabsVm Vm => BindingContext as TabsVm;

        public TabsPage(TabsVm vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            //Vm.RefreshCommand.Execute(null);
        }

        protected override void OnBindingContextChanged()
        {
            if (!(Vm?.Pages.Count > 0)) return;

            base.OnBindingContextChanged();
        }
    }
}