using Modal.ViewModels;

namespace Modal.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainVm vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }

}
