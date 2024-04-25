using System.Globalization;
using System.Windows.Input;
using Windows.System;
using Windows.UI.Input.Preview.Injection;

namespace EntriesAndKeyboards.Views;

public partial class KeyboardNumeric : ContentView
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

    public KeyboardNumeric()
    {
        InitializeComponent();

        separator.Text = DecimalSeparator;
    }

    public string DecimalSeparator { get; } = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;

    readonly InputInjector inputInjector = InputInjector.TryCreate();

    private void NumberInput_Clicked(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        InjectedInputKeyboardInfo info = new() { KeyOptions = InjectedInputKeyOptions.Unicode, ScanCode = btn.Text[0] };
        inputInjector.InjectKeyboardInput([info]);
        TargetEntry.Focus();
    }

    private void Clear_Clicked(object sender, EventArgs e)
    {
        TargetEntry.Text = "";
        TargetEntry.Focus();
    }

    private void Separator_Clicked(object sender, EventArgs e)
    {
        if (!TargetEntry.Text.Contains(DecimalSeparator))
        {
            InjectedInputKeyboardInfo info = new() { KeyOptions = InjectedInputKeyOptions.Unicode, ScanCode = DecimalSeparator[0] };
            inputInjector.InjectKeyboardInput([info]);
        }
        TargetEntry.Focus();
    }

    private void Go_Clicked(object sender, EventArgs e)
    {
        GoCommand?.Execute(decimal.Parse(TargetEntry.Text));
        TargetEntry.Focus();
        InjectedInputKeyboardInfo info = new() { VirtualKey = (ushort)VirtualKey.Tab };
        inputInjector.InjectKeyboardInput([info]);
    }

    public static readonly BindableProperty TargetEntryProperty =
        BindableProperty.Create(nameof(TargetEntry), typeof(ITextInput), typeof(KeyboardNumeric), null, BindingMode.TwoWay);

    public static readonly BindableProperty GoCommandProperty =
        BindableProperty.Create(nameof(GoCommand), typeof(ICommand), typeof(KeyboardNumeric));
}