using System.Windows.Input;
using TransBinding.ViewModels;

namespace TransBinding.Views;

public partial class SelectorComponent : ContentView
{
    public SelectorComponentVm Vm => BindingContext as SelectorComponentVm;

    public ICommand ItemSelectedCommand
	{
		get => (ICommand)GetValue(ItemSelectedCommandProperty); 
		set { SetValue(ItemSelectedCommandProperty, value); }
	}

	public ItemSize ItemSize
	{
		get => (ItemSize)GetValue(ItemSizeProperty);
		set { SetValue(ItemSizeProperty, value); }
	}

	public SelectorComponent()
	{
		InitializeComponent();
		BindingContext = new SelectorComponentVm();
    }

	public static readonly BindableProperty ItemSelectedCommandProperty = BindableProperty.Create(nameof(ItemSelectedCommand), typeof(ICommand), typeof(SelectorComponent), null, BindingMode.TwoWay, propertyChanged: ItemSetectedCommandChanged);

	public static readonly BindableProperty ItemSizeProperty = BindableProperty.Create(nameof(ItemSize), typeof(ItemSize), typeof(SelectorComponent), ItemSize.M, BindingMode.TwoWay, propertyChanged: ItemSizeChanged);

	private static void ItemSizeChanged(BindableObject bindable, object oldValue, object newValue)
	{
		(bindable as SelectorComponent).Vm.SetItemSize((ItemSize)newValue);
	}

	private static void ItemSetectedCommandChanged(BindableObject bindable, object oldValue, object newValue)
    {
        (bindable as SelectorComponent).Vm.SetItemSize((ItemSize)newValue);
    }
}