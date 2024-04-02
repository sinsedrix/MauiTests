using CommunityToolkit.Mvvm.ComponentModel;

namespace Modal.ViewModels
{
    public partial class ChoiceVm : ObservableObject
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
