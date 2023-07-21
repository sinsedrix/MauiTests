using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace MauiCommandAssign.ViewModels;

public partial class ModeVm : ObservableObject
{
    [ObservableProperty]
    string label;

    [ObservableProperty]
    ICommand command;
}
