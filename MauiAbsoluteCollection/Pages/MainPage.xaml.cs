namespace MauiAbsoluteCollection.Pages;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void Button4_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Page4));
    }

	private async void Button5_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Page5));
    }
}

