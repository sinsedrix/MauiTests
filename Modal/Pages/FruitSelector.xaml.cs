using Modal.ViewModels;

namespace Modal.Pages;

public partial class FruitSelector : ContentPage
{
	public FruitSelector(FruitSelectorVm vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}