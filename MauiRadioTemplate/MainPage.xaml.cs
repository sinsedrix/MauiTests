namespace MauiRadioTemplate
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainVm vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            Console.WriteLine($"Alpha : {rbAlpha?.IsChecked}");
            Console.WriteLine($"Beta : {rbBeta?.IsChecked}");
            Console.WriteLine($"Gamma : {rbGamma?.IsChecked}");
        }
    }
}