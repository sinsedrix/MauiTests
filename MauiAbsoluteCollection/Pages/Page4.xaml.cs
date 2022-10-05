using MauiAbsoluteCollection.ViewModels;

namespace MauiAbsoluteCollection.Pages;

public partial class Page4 : ContentPage
{
	public Page4(AbsoluteListVm vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}