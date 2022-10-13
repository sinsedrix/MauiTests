using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;

namespace TransBinding.ViewModels
{
    public partial class MainVm : ObservableObject
    {
        [ObservableProperty]
        ItemSize selectedSize;

        public List<ItemSize> Sizes { get; } = Enum.GetValues<ItemSize>().ToList();

        [RelayCommand]
        async Task SelectItemAsync(object o)
        {
            ItemVm vm = o as ItemVm;
            var field = typeof(ItemSize).GetField($"{vm.Size}");
            DescriptionAttribute attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            await Shell.Current.DisplayAlert("Info", $"Your {attr.Description} {vm.Name} is {(vm.Alive ? "alive": "dead")}!", "OK");
        }
    }
}
