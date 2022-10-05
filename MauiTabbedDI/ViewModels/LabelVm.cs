using CommunityToolkit.Mvvm.ComponentModel;
using MauiTabbedDI.Models;

namespace MauiTabbedDI.ViewModels;

public partial class LabelVm : BaseVm
{
    [ObservableProperty]
    string origin;

    [ObservableProperty]
    MLabel label = new();

    public LabelVm()
    {
        Label = new MLabel { Text = Guid.NewGuid().ToString() };
    }
}