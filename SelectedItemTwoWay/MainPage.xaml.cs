namespace SelectedItemTwoWay
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