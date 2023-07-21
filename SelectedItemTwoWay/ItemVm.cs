using CommunityToolkit.Mvvm.ComponentModel;

namespace SelectedItemTwoWay;

public partial class ItemVm : ObservableObject
{
    [ObservableProperty]
    string itemLabel;
}