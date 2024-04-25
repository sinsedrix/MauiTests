using EntriesAndKeyboards.Utils;

namespace EntriesAndKeyboards
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.AddKeyboards(kbStack);
        }

    }

}
