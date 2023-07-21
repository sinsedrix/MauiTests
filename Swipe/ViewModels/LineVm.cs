using CommunityToolkit.Mvvm.ComponentModel;

namespace Swipe.ViewModels
{
    public partial class LineVm : ObservableObject
    {
        [ObservableProperty]
        int quantity;

        [ObservableProperty]
        string description;

        [ObservableProperty]
        double price;

    }
}
