using EntriesAndKeyboards.Views;

namespace EntriesAndKeyboards.Utils
{
    public static class PageExt
    {
        public static void AddKeyboards(this ContentPage p, Layout l)
        {
            var kbTxt = new KeyboardText { IsVisible = false };
            l.Children.Add(kbTxt);

            var kbNum = new KeyboardNumeric { IsVisible = false };
            l.Children.Add(kbNum);

            List<Entry> entries = p.Content.GetVisualTreeDescendants().OfType<Entry>().ToList();
            foreach (Entry entry in entries)
            {
                entry.Focused += Entry_Focused;
            }

            void Entry_Focused(object sender, FocusEventArgs e)
            {
                Entry entry = sender as Entry;
                if (entry.Keyboard == Keyboard.Numeric)
                {
                    kbNum.TargetEntry = entry;
                    kbNum.IsVisible = true;
                    kbTxt.IsVisible = false;
                }
                else
                {
                    kbTxt.TargetEntry = entry;
                    kbTxt.IsVisible = true;
                    kbNum.IsVisible = false;
                }
            }
        }
    }
}