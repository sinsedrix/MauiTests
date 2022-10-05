using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiRadioTemplate
{
    public partial class MainVm : ObservableObject
    {
        public bool IsAlphaType => SelectedType == ETestType.Alpha;
        public bool IsBetaType => SelectedType == ETestType.Beta;
        public bool IsGammaType => SelectedType == ETestType.Gamma;

        ETestType selectedType;
        public ETestType SelectedType
        {
            get => selectedType;
            set 
            {
                selectedType = value; 
                OnPropertyChanged(); 
                OnPropertyChanged(nameof(IsAlphaType));
                OnPropertyChanged(nameof(IsBetaType));
                OnPropertyChanged(nameof(IsGammaType));
            }
        }
    }
}