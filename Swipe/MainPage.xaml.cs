using Swipe.ViewModels;

namespace Swipe
{
    public partial class MainPage : ContentPage
    {
        MainVm Vm => BindingContext as MainVm;

        public MainPage(MainVm vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}