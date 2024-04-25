namespace EntriesAndKeyboards.Utils
{
    internal static class ResourceHelper
    {
        public static T FindResource<T>(string key) where T : class
        {
            return Application.Current.Resources.MergedDictionaries.Select(d =>
                    d.TryGetValue(key, out object o) && o is T s ? s : null
                ).FirstOrDefault(s => s is not null);
        }
    }
}
