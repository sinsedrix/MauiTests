using System.Windows.Input;
using TransBinding.ViewModels;

namespace TransBinding.Views;

public partial class Item : ContentView
{
    public Item()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		(BindingContext as ItemVm).ItemSelectedCommand?.Execute(null);
    }
}