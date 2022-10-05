using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiCommandAssign.ViewModels
{
    public partial class ModeVm : ObservableObject
    {
        [ObservableProperty]
        string label;

        [ObservableProperty]
        ICommand command;
    }
}
