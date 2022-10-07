using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace TransBinding.ViewModels
{
    public partial class ItemVm : ObservableObject
    {
        [ObservableProperty]
        string name;

        [ObservableProperty]
        bool alive = true;

        [ObservableProperty]
        ItemSize size;

        [ObservableProperty]
        ICommand itemSelectedCommand;
    }

    public enum ItemSize
    {
        XS, S, M, L, XL
    }
}
