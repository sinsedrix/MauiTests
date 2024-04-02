using Modal.ViewModels;

namespace Modal.Pages;

public partial class TestPage : ContentPage
{
	TestVm Vm => BindingContext as TestVm;

    public TestPage(TestVm vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}