using CommunityToolkit.Mvvm.ComponentModel;

namespace StatusPage;

public partial class MainVm : ObservableObject
{
    [ObservableProperty]
    StatusVm status;

    public MainVm(StatusVm status)
    {
        this.status = status;

    }

}

