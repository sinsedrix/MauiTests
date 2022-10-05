using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiTabbedDI.ViewModels;

public partial class TabsVm : BaseVm
{
    public ObservableCollection<LabelVm> Pages { get; } = new();

    public TabsVm()
    {
        Pages.Add(new LabelVm { Title = "No page" });
    }

    [RelayCommand]
    void Refresh()
    {
        Pages.Clear();

        List<LabelVm> pages = new()
        {
            new LabelVm { Title = "Page 1" },
            new LabelVm { Title = "Page 2" },
            new LabelVm { Title = "Page 3" },
        };

        foreach (LabelVm p in pages) Pages.Add(p);
    }
}