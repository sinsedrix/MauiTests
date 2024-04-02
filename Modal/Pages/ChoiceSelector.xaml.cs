using Modal.ViewModels;

namespace Modal.Pages;

public partial class ChoiceSelector : ContentPage
{
	public ChoiceSelector(ChoiceSelectorVm vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}