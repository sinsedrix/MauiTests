using Modal.ViewModels;

namespace Modal
{
    public static class ShellExt
    {
        public static async Task GoToAsync<T>(this Shell shell, string query = null) where T : Page
        {
            string q = !string.IsNullOrEmpty(query) ? $"?{query}" : null;
            await shell.GoToAsync(typeof(T).Name + q);
        }

        public static async Task<TR> GetModalResultAsync<TP, TR>(this Shell shell, TR initVal = default) where TP : Page
        {
            Page page = App.Current.Container.GetService<TP>();
            BaseModalVm<TR> vm = page.BindingContext as BaseModalVm<TR>;
            vm.SelectedValue = initVal;

            await shell.Navigation.PushModalAsync(page);

            vm.Selected += async (s, e) => await shell.PopModalAsync();

            return await vm.GetResultAsync();
        }

        public static async Task PopModalAsync(this Shell shell, bool animated = false)
        {
            await shell.Navigation.PopModalAsync(animated);
        }
    }
}
