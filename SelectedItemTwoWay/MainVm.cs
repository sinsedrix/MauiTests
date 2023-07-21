using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace SelectedItemTwoWay;

public partial class MainVm : ObservableObject
{

    public ObservableCollection<ItemVm> Items1 { get; } = new();

    [ObservableProperty]
    ItemVm selectedItem1;

    public ObservableCollection<ItemVm> Items2 { get; } = new();


    static readonly string[] Labels = new[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

    public MainVm()
    {
        foreach (var lbl in Labels) 
        {
            Items1.Add(new ItemVm() { ItemLabel = lbl });
            Items2.Add(new ItemVm() { ItemLabel = lbl });
        }
    }

    [RelayCommand]
    void SelectItem(string lbl)
    {
        var it = Items1.FirstOrDefault(i =>  i.ItemLabel == lbl);

        SelectedItem1 = it;
    }
}