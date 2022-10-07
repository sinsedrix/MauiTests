using System.Windows.Input;
using TransBinding.ViewModels;

namespace TransBinding.Views;

public partial class SelectorComponent : ContentView
{
    public ICommand ItemSelectedCommand
	{
		get => (ICommand)GetValue(ItemSelectedCommandProperty); 
		set { SetValue(ItemSelectedCommandProperty, value); Vm.ItemSelectedCommand = value; }
	}

	public ItemSize ItemSize
	{
		get => (ItemSize)GetValue(ItemSizeProperty);
		set { SetValue(ItemSizeProperty, value); Vm.ItemSize = value; }
	}

    public SelectorComponentVm Vm { get; }

	public SelectorComponent()
	{
		InitializeComponent();

        Vm = new SelectorComponentVm();
		BindingContext = this;
    }

	public static readonly BindableProperty ItemSelectedCommandProperty = BindableProperty.Create(nameof(ItemSelectedCommand), typeof(ICommand), typeof(SelectorComponent));
    public static readonly BindableProperty ItemSizeProperty = BindableProperty.Create(nameof(ItemSize), typeof(ItemSize), typeof(SelectorComponent));
}