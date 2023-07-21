using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swipe.Views
{
    public class ParityTemplateSelector<T> : DataTemplateSelector
    {
        public DataTemplate EvenTemplate { get; set; }
        public DataTemplate OddTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return item is T vm && ((ObservableCollection<T>)((CollectionView)container).ItemsSource).IndexOf(vm) % 2 == 0 ? EvenTemplate : OddTemplate;
        }
    }
}
