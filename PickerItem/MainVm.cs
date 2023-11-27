using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace PickerItem
{
    internal partial class MainVm : ObservableObject
    {
        [ObservableProperty]
        Choice selectedChoice;

        public ObservableCollection<Choice> Choices { get; } = new();

        [ObservableProperty]
        string selectedStrChoice;
        public ObservableCollection<string> StrChoices { get; } = new();

        public MainVm() 
        {
            string[] strChoices = new string[]
            {
                "First",
                "Second",
                "Third",
                "Fourth",
                "Fifth",
                "Sixth"
            };
            foreach (string choice in strChoices)
            {
                StrChoices.Add(choice);
            }
            SelectedStrChoice = StrChoices.First();

            Choice[] choices = new Choice[]
            {
                new() { Id = 1, Name = "First" },
                new() { Id = 2, Name = "Second" },
                new() { Id = 3, Name = "Third" },
                new() { Id = 4, Name = "Fourth" },
                new() { Id = 5, Name = "Fifth" },
                new() { Id = 6, Name = "Sixth" },
            };
            foreach (Choice choice in choices)
            {
                Choices.Add(choice);
            }
            
            SelectedChoice = Choices.First();
        }
    }
}
