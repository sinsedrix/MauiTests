using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiCommandAssign.ViewModels
{
    public partial class MainVm : ObservableObject
    {
        public ObservableCollection<ModeVm> Modes { get; } = new();

        public MainVm()
        {
            Modes = new ObservableCollection<ModeVm>()
            {
                new ModeVm { Label = "Mode 1", Command = DoModeCommand },
                new ModeVm { Label = "Mode 2", Command = DoModeCommand },
                new ModeVm { Label = "Mode 3", Command = DoModeCommand },
            };
        }

        [RelayCommand]
        async Task DoModeAsync(ModeVm vm)
        {
            await Shell.Current.DisplayAlert("Info", $"{vm.Label} activated", "OK");
        }

    }
}
