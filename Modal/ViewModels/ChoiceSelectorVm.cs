using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Modal.ViewModels
{
    public partial class ChoiceSelectorVm : BaseModalVm<ChoiceVm>
    {
        [ObservableProperty]
        ChoiceVm selectedChoice;

        public ObservableCollection<ChoiceVm> Choices { get; } = new();

        public ChoiceSelectorVm() 
        {
            Choices.Add(new ChoiceVm { Id = 1, Description = "Banana"} );
            Choices.Add(new ChoiceVm { Id = 2, Description = "Apple"} );
            Choices.Add(new ChoiceVm { Id = 3, Description = "Pear"} );
            Choices.Add(new ChoiceVm { Id = 4, Description = "Cherry"} );
            Choices.Add(new ChoiceVm { Id = 5, Description = "Strawberry" } );
        }

        [RelayCommand]
        void Select()
        {
            SelectAction?.Invoke(SelectedChoice);
        }


        [RelayCommand]
        void Cancel()
        {
            SelectAction?.Invoke(null);
        }
    }
}
