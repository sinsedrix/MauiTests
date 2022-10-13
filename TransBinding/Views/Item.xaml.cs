using System.Windows.Input;
using TransBinding.ViewModels;

namespace TransBinding.Views;

public partial class Item : ContentView
{
	public ItemVm Vm => BindingContext as ItemVm;

    public Item()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Vm.ItemSelectedCommand?.Execute(Vm);
    }
}