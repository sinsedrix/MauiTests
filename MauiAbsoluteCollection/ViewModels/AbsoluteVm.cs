using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAbsoluteCollection.ViewModels
{
    public partial class AbsoluteVm : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(LayoutBounds))]
        int x;
        
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(LayoutBounds))]
        int y;

        [ObservableProperty]
        string label;

        public Rect LayoutBounds => new(X, Y, 100, 50);

        public AbsoluteVm() { }

        [RelayCommand]
        async Task Tap()
        {
            await Shell.Current.DisplayAlert("Info", $"{Label} clicked", "OK");
        }
    }
}
