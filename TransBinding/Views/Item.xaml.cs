using System.Windows.Input;

namespace TransBinding.Views;

public partial class Item : ContentView
{
    public ICommand ItemSelectedCommand
    {
        get => (ICommand)GetValue(ItemSelectedCommandProperty);
        set => SetValue(ItemSelectedCommandProperty, value);
    }

    public string ItemStatus
    {
        get => (string)GetValue(ItemStatusProperty);
        set => SetValue(ItemStatusProperty, value);
    }

    public Item()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty ItemSelectedCommandProperty = BindableProperty.Create(nameof(ItemSelectedCommand), typeof(ICommand), typeof(SelectorComponent));
    public static readonly BindableProperty ItemStatusProperty = BindableProperty.Create(nameof(ItemStatus), typeof(string), typeof(SelectorComponent));
}