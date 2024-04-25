using EntriesAndKeyboards.Utils;
using System.Globalization;
using System.Windows.Input;
using Windows.System;
using Windows.UI.Input.Preview.Injection;

namespace EntriesAndKeyboards.Views;

public partial class KeyboardText : ContentView
{
    public Entry TargetEntry
    {
        get => (Entry)GetValue(TargetEntryProperty);
        set
        {
            SetValue(TargetEntryProperty, value);
        }
    }
    public ICommand GoCommand
    {
        get => (ICommand)GetValue(GoCommandProperty);
        set
        {
            SetValue(GoCommandProperty, value);
        }
    }


    private int BoardIndex;

    readonly char[][] azertyKb =
    [
        ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
        ['a', 'z', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'],
        ['q', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm'],
        ['@', 'w', 'x', 'c', 'v', 'b', 'n', '\'', ',', '.']
    ];

    readonly char[][] qwertyKb =
    [
        ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
        ['q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'],
        ['a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', '?'],
        ['@', 'z', 'x', 'c', 'v', 'b', 'n', 'm', ',', '.']
    ];

    readonly char[][] specialKb =
    [
        ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
        ['@', '#', '_', '&', ':', ';', '°', '?', '!', '.'],
        ['"', '\'',  '{', '}', '[', ']', '(', ')', '/', '\\'],
        ['€', '$', '£', '%', '=', '-', '+', '÷', '×', '*']
    ];

    readonly InputInjector inputInjector = InputInjector.TryCreate();

    public KeyboardText()
    {
        InitializeComponent();

        CultureInfo culture = CultureInfo.CurrentCulture;
        char[][] lowerKb = culture.Name.StartsWith("fr") ? azertyKb : qwertyKb;
        AddBoard(lowerKbGrid, lowerKb);
        char[][] upperKb = Enumerable.Range(0, 4)
            .Select(j => Enumerable.Range(0, 10)
                .Select(i => char.ToUpper(lowerKb[j][i]))
                .ToArray())
            .ToArray();
        AddBoard(upperKbGrid, upperKb);

        AddBoard(specialKbGrid, specialKb);

        SetVisibleBoard(0);

        
    }

    void AddBoard(Grid grid, char[][] board)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                char caractere = board[j][i];

                // Créer un bouton avec le caractère actuel
                Button bouton = new()
                {
                    Text = caractere.ToString(),
                    Style = ResourceHelper.FindResource<Style>("KeyButtonStyle")
                };
                bouton.Clicked += KeyInput_Clicked;

                // Ajouter le bouton à la grille à la position actuelle
                Grid.SetRow(bouton, j);
                Grid.SetColumn(bouton, i);
                grid.Children.Add(bouton);
            }
        }
    }


    private void KeyInput_Clicked(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        TargetEntry.Focus();
        InjectedInputKeyboardInfo info = new() { KeyOptions = InjectedInputKeyOptions.Unicode, ScanCode = btn.Text[0] };
        inputInjector.InjectKeyboardInput([info]);
    }

    private void SpaceInput_Clicked(object sender, EventArgs e)
    {
        TargetEntry.Focus();
        InjectedInputKeyboardInfo info = new() { VirtualKey = ' ' };
        inputInjector.InjectKeyboardInput([info]);
    }

    private void Clear_Clicked(object sender, EventArgs e)
    {
        TargetEntry.Text = "";
        TargetEntry.Focus();
    }

    private void Backspace_Clicked(object sender, EventArgs e)
    {
        TargetEntry.Focus();
        InjectedInputKeyboardInfo info = new() { VirtualKey = (ushort)VirtualKey.Back };
        inputInjector.InjectKeyboardInput([info]);
    }

    private void ToggleBoard_Clicked(object sender, EventArgs e)
    {
        SetVisibleBoard((BoardIndex + 1) % 3);
        TargetEntry.Focus();
    }

    void SetVisibleBoard(int i)
    {
        BoardIndex = i;
        upperKbGrid.IsVisible = i == 0;
        lowerKbGrid.IsVisible = i == 1;
        specialKbGrid.IsVisible = i == 2;
    }


    private void Go_Clicked(object sender, EventArgs e)
    {
        GoCommand?.Execute(TargetEntry.Text);
        TargetEntry.Focus();
        InjectedInputKeyboardInfo info = new() { VirtualKey = (ushort)VirtualKey.Tab };
        inputInjector.InjectKeyboardInput([info]);
    }

    public static readonly BindableProperty TargetEntryProperty =
        BindableProperty.Create(nameof(TargetEntry), typeof(Entry), typeof(KeyboardText), null, BindingMode.TwoWay);

    public static readonly BindableProperty GoCommandProperty =
        BindableProperty.Create(nameof(GoCommand), typeof(ICommand), typeof(KeyboardText));
}