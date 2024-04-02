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

        public static async Task<TR> GetModalResultAsync<TP, TR>(this Shell shell) where TP : Page
        {
            Page page = App.Current.Container.GetService<TP>();
            await shell.Navigation.PushModalAsync(page);
            BaseModalVm<TR> vm = page.BindingContext as BaseModalVm<TR>;

            return await vm.GetResultAsync();
        }

        public static async Task PopModalAsync(this Shell shell, bool animated = false)
        {
            await shell.Navigation.PopModalAsync(); // animated
        }
    }
}
