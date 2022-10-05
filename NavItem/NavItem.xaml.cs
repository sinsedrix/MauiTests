namespace NavItem;

public partial class NavItem : ContentView
{
    public string Texto
    {
        get => (string)GetValue(TextoProperty);
        set { SetValue(TextoProperty, value); OnPropertyChanged(); }
    }

    public string PageName { get; set; }

    public NavItem()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(PageName);
    }

    public static readonly BindableProperty TextoProperty = BindableProperty.Create(nameof(Texto), typeof(string), typeof(NavItem));
}