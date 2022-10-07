using TransBinding.ViewModels;

namespace TransBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainVm vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        //public MainPage()
        //{
        //    InitializeComponent();
        //}

    }
}