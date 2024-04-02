using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Modal.Pages;

namespace Modal.ViewModels
{
    public partial class TestVm : ObservableObject
    {
        [ObservableProperty]
        string chosenFruit;

        public async Task RefreshAsync()
        {
            
        }

        [RelayCommand]
        async Task GoToChoicePageAsync()
        {
            ChoiceVm c = await Shell.Current.GetModalResultAsync<ChoiceSelector, ChoiceVm>();

            ChosenFruit = c?.Description;
        }
    }

}
