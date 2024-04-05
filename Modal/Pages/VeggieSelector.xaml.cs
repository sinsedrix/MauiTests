using Modal.ViewModels;

namespace Modal.Pages;

public partial class VeggieSelector : ContentPage
{
	public VeggieSelector(VeggieSelectorVm vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}