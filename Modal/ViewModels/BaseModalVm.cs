using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Modal.ViewModels
{
    public partial class BaseModalVm<T> : ObservableObject
    {
        [ObservableProperty]
        T selectedValue;

        public event EventHandler<T> Selected;
        private TaskCompletionSource<T> taskCompletionSource;

        public async Task<T> GetResultAsync()
        {
            taskCompletionSource = new TaskCompletionSource<T>();

            return await taskCompletionSource.Task;
        }

        [RelayCommand]
        void Select()
        {
            Selected?.Invoke(this, SelectedValue);
            taskCompletionSource.SetResult(SelectedValue);
        }


        [RelayCommand]
        void Cancel()
        {
            Selected?.Invoke(this, default);
            taskCompletionSource.SetResult(default);
        }
    }

}
