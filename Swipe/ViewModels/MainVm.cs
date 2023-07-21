using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Swipe.ViewModels
{
    public partial class MainVm : ObservableObject
    {
        private static readonly Random random = new();

        public static string RandomString(int length)
        {
            const string chars = " abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ 0123456789";
            return new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        public ObservableCollection<LineVm> Lines { get; } = new();

        public LineVm FirstLine => Lines.FirstOrDefault();

        public MainVm() 
        {
            IEnumerable<LineVm> lines = Enumerable.Range(1, 6).Select(i => new LineVm
            {
                Description = RandomString(random.Next(10) + 4),
                Quantity = 0,
                Price = random.NextDouble() * 100
            });
            foreach(var l in lines)
            {
                Lines.Add(l);
            }
            OnPropertyChanged(nameof(FirstLine));
        }
        
        [RelayCommand]
        void LinePlus(LineVm ln)
        {
            ln.Quantity++;
        }


        [RelayCommand]
        void LineMinus(LineVm ln)
        {
            if(ln.Quantity > 0)
            {
                ln.Quantity--;
            }
        }
    }
}
