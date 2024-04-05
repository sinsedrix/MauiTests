using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Modal.Pages;

namespace Modal.ViewModels
{
    public partial class MainVm : ObservableObject
    {
        [ObservableProperty]
        string chosenFruit;

        [ObservableProperty]
        string chosenVeggie;

        [RelayCommand]
        async Task GoToTestPage()
        {
            await Shell.Current.GoToAsync<TestPage>();
        }

        [RelayCommand]
        async Task GoToFruitPageAsync()
        {
            ChoiceVm c = await Shell.Current.GetModalResultAsync<FruitSelector, ChoiceVm>();

            ChosenFruit = c?.Description;
        }

        [RelayCommand]
        async Task GoToVeggiePageAsync()
        {
            ChoiceVm c = await Shell.Current.GetModalResultAsync<VeggieSelector, ChoiceVm>();

            ChosenVeggie = c?.Description;
        }
    }
}
