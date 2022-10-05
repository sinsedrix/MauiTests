using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTabbedDI.ViewModels;

public abstract partial class BaseVm : ObservableObject
{
    [ObservableProperty]
    string title;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    public bool IsNotBusy => !isBusy;

    public static T New<T>() where T : BaseVm
    {
        return ActivatorUtilities.CreateInstance<T>(MauiTabbedDI.ServiceProvider.Current);
    }
}