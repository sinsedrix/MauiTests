using MauiTabbedDI.ViewModels;

namespace MauiTabbedDI.Pages;

public partial class LabelPage : ContentPage
{
    LabelVm Vm => BindingContext as LabelVm;

	public LabelPage()
	{
		InitializeComponent();
	}

    public LabelPage(LabelVm vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override void OnBindingContextChanged()
    {
        if (Vm is null) return;

        base.OnBindingContextChanged();
    }
}