using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;
using Windows.Foundation.Metadata;

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
        [Description("Extra Small")]
        XS,
        [Description("Small")]
        S,
        [Description("Medium")]
        M,
        [Description("Large")]
        L,
        [Description("Extra Large")]
        XL
    }
}
