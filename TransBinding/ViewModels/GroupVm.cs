using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace TransBinding.ViewModels;

public partial class GroupVm : ObservableObject
{
    [ObservableProperty]
    string name;

    public ObservableCollection<ItemVm> Items { get; set; } = new();
}
