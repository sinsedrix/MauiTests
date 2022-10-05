using MauiAbsoluteCollection.ViewModels;

namespace MauiAbsoluteCollection.Pages;

public partial class Page5 : ContentPage
{
	public Page5(AbsoluteListVm vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}