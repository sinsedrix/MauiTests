using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Modal.Pages;

namespace Modal.ViewModels
{
    public partial class MainVm : ObservableObject
    {

        [RelayCommand]
        async Task GoToTestPage()
        {
            await Shell.Current.GoToAsync<TestPage>();
        }
    }
}
