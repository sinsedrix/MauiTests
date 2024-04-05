using System.Collections.ObjectModel;

namespace Modal.ViewModels
{
    public partial class FruitSelectorVm : BaseModalVm<ChoiceVm>
    {
        public ObservableCollection<ChoiceVm> Fruits { get; } = new();

        public FruitSelectorVm() 
        {
            Fruits.Add(new ChoiceVm { Id = 1, Description = "Banana"} );
            Fruits.Add(new ChoiceVm { Id = 2, Description = "Apple"} );
            Fruits.Add(new ChoiceVm { Id = 3, Description = "Pear"} );
            Fruits.Add(new ChoiceVm { Id = 4, Description = "Cherry"} );
            Fruits.Add(new ChoiceVm { Id = 5, Description = "Strawberry" } );
        }
    }
}
