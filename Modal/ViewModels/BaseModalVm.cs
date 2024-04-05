using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Modal.ViewModels
{
    public partial class BaseModalVm<T> : ObservableObject
    {
        [ObservableProperty]
        T selectedValue;

        public Action<T> SelectAction { get; private set; }

        public async Task<T> GetResultAsync()
        {
            var tcs = new TaskCompletionSource<T>();

            SelectAction = async (result) =>
            {
                SelectedValue = result;
                tcs.SetResult(result); // Définit le résultat de la tâche
                await Shell.Current.PopModalAsync(); // Ferme la page modale
            };

            return await tcs.Task; // Attendez que la tâche soit terminée et renvoyez le résultat
        }

        [RelayCommand]
        void Select()
        {
            SelectAction?.Invoke(SelectedValue);
        }


        [RelayCommand]
        void Cancel()
        {
            SelectAction?.Invoke(default);
        }
    }

}
