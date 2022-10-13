using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TransBinding.ViewModels
{
    public partial class MainVm : ObservableObject
    {
        [ObservableProperty]
        ItemSize selectedSize = ItemSize.M;

        public List<ItemSize> Sizes { get; } = Enum.GetValues<ItemSize>().ToList();

        [RelayCommand]
        async Task SelectItemAsync(ItemVm item)
        {
            await Shell.Current.DisplayAlert("Info", $"Your {item.Size} {item.Name} is {(item.Alive ? "alive": "dead")}!", "OK");
        }
    }
}
