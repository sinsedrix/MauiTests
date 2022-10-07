using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace TransBinding.ViewModels
{
    public partial class SelectorComponentVm : ObservableObject
    {
        public ItemSize ItemSize
        {
            set
            {
                foreach(var grp in Groups)
                        foreach (var item in grp.Items)
                            item.Size = value;
            }
        }

        public ICommand ItemSelectedCommand
        {
            set
            {
                foreach (var grp in Groups)
                        foreach (var item in grp.Items)
                            item.ItemSelectedCommand = value;
            }
        }

        readonly Timer _timer;
        public ObservableCollection<GroupVm> Groups { get; } = new();

        public SelectorComponentVm()
        {
            _timer = new Timer((s) => _ = RefreshAsync(), null, TimeSpan.FromSeconds(1), TimeSpan.FromMinutes(1));
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
        }
    }
}
