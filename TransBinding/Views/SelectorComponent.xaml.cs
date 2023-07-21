using CommunityToolkit.Mvvm.Input;
using TransBinding.ViewModels;

namespace TransBinding.Views;

public partial class SelectorComponent : ContentView
{
    public SelectorComponentVm Vm => BindingContext as SelectorComponentVm;

    public IRelayCommand<object> ItemSelectedCommand
	{
		get => (IRelayCommand<object>)GetValue(ItemSelectedCommandProperty); 
		set { SetValue(ItemSelectedCommandProperty, value); Vm.SetItemSelectedCommand(value); }
	}

	public ItemSize ItemSize
	{
		get => (ItemSize)GetValue(ItemSizeProperty);
		set { SetValue(ItemSizeProperty, value); Vm.SetItemSize(value); }
	}

	public bool IsReady => Vm.IsReady;

    public SelectorComponent()
	{
		InitializeComponent();
		BindingContext = new SelectorComponentVm();
    }

	public static readonly BindableProperty ItemSelectedCommandProperty = BindableProperty.Create(nameof(ItemSelectedCommand), typeof(IRelayCommand<object>), typeof(SelectorComponent), null, BindingMode.OneWay);

    public static readonly BindableProperty ItemSizeProperty = BindableProperty.Create(nameof(ItemSize), typeof(ItemSize), typeof(SelectorComponent), ItemSize.M, BindingMode.OneWay);
}