using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Modal.Pages;

namespace Modal.ViewModels
{
    public partial class TestVm : ObservableObject
    {
        [ObservableProperty]
        string chosenFruit;


        [ObservableProperty]
        string chosenVeggie;

        public async Task RefreshAsync()
        {
            
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
