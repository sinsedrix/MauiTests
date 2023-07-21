using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swipe.ViewModels
{
    public class MainVm
    {
        public ObservableCollection<LineVm> Lines { get; } = new();

        public MainVm() 
        {
            IEnumerable<LineVm> lines = Enumerable.Range(0, 10).Select(i => new LineVm
            {
                Description = $"Label {i}",
                Id = i.ToString(),
                Price = new Random().NextDouble() * 100
            });
            foreach(var l in lines)
            {
                Lines.Add(l);
            }
        }
    }
}
