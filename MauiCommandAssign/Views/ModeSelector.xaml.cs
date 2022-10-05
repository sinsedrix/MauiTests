using MauiCommandAssign.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiCommandAssign.Views;

public partial class ModeSelector : ContentView
{
    public ICommand ModeCommand 
    {
        get => (ICommand)GetValue(ModeCommandProperty);
        private set => SetValue(ModeCommandProperty, value);
    }

    public IEnumerable<ModeVm> Modes
    {
        get => (IEnumerable<ModeVm>)GetValue(ModesProperty);
        private set => SetValue(ModesProperty, value);
    }

    public ModeSelector()
	{
		InitializeComponent();
    }


    public static readonly BindableProperty ModeCommandProperty =
        BindableProperty.Create(nameof(ModeCommand), typeof(ICommand), typeof(ModeSelector));

    public static readonly BindableProperty ModesProperty =
        BindableProperty.Create(nameof(Modes), typeof(IEnumerable<ModeVm>), typeof(ModeSelector));
}