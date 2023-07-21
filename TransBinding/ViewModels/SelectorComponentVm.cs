using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace TransBinding.ViewModels;

public partial class SelectorComponentVm : ObservableObject
{
    public void SetItemSize(ItemSize size)
    {
        foreach(var grp in Groups)
                foreach (var item in grp.Items)
                    item.Size = size;
    }

    public void SetItemSelectedCommand(IRelayCommand<object> cmd)
    {
        foreach (var grp in Groups)
                foreach (var item in grp.Items)
                    item.ItemSelectedCommand = cmd;
    }

    readonly Timer _timer;
    public ObservableCollection<GroupVm> Groups { get; } = new();

    [ObservableProperty]
    bool isReady;

    public SelectorComponentVm()
    {
        _timer = new Timer((s) => _ = RefreshAsync(), null, TimeSpan.FromSeconds(1), TimeSpan.FromMinutes(5));
    }

    ~SelectorComponentVm() => _timer?.Dispose();

    public async Task RefreshAsync()
    {
        await Task.Delay(100);

        Groups.Clear();
        Groups.Add(new GroupVm
        {
            Name =  "Group A",
            Items = new ObservableCollection<ItemVm>
            {
                new ItemVm { Name = "Cat" },
                new ItemVm { Name = "Dog" },
            }
        });
        Groups.Add(new GroupVm
        {
            Name = "Group B",
            Items = new ObservableCollection<ItemVm>
            {
                new ItemVm { Name = "Donkey" },
                new ItemVm { Name = "Horse" },

                new ItemVm { Name = "Monkey" },
                new ItemVm { Name = "Lemur" },
            }
        });
        Groups.Add(new GroupVm
        {
            Name = "Group C",
            Items = new ObservableCollection<ItemVm>
            {
                new ItemVm { Name = "Pig" },
                new ItemVm { Name = "Boar" },
            }
        });

        IsReady = true;
    }
}
