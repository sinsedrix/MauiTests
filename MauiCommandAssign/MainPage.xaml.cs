using MauiCommandAssign.ViewModels;

namespace MauiCommandAssign;

public partial class MainPage : ContentPage
{
	public MainPage(MainVm vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

