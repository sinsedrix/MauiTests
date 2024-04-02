using CommunityToolkit.Mvvm.ComponentModel;

namespace Modal.ViewModels
{
    public class BaseModalVm<T> : ObservableObject
    {
        public Action<T> SelectAction { get; set; }

        public async Task<T> GetResultAsync()
        {
            var tcs = new TaskCompletionSource<T>();

            SelectAction = async (result) =>
            {
                tcs.SetResult(result); // Définit le résultat de la tâche
                await Shell.Current.PopModalAsync(); // Ferme la page modale
            };

            return await tcs.Task; // Attendez que la tâche soit terminée et renvoyez le résultat
        }
    }

}
