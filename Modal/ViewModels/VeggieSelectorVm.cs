using System.Collections.ObjectModel;

namespace Modal.ViewModels
{
    public partial class VeggieSelectorVm : BaseModalVm<ChoiceVm>
    {
        public ObservableCollection<ChoiceVm> Veggies { get; } = new();

        public VeggieSelectorVm() 
        {
            Veggies.Add(new ChoiceVm { Id = 1, Description = "Carrot"} );
            Veggies.Add(new ChoiceVm { Id = 2, Description = "Potatoe"} );
            Veggies.Add(new ChoiceVm { Id = 3, Description = "Tomato"} );
            Veggies.Add(new ChoiceVm { Id = 4, Description = "Salad"} );
            Veggies.Add(new ChoiceVm { Id = 5, Description = "Cucumber" } );
        }
    }
}
