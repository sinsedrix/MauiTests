namespace Swipe.Views;

public partial class Line : ContentView
{
	public Line()
	{
		InitializeComponent();
	}

    public Color ItemColor
    {
        get => (Color)GetValue(ItemColorProperty);
        set => SetValue(ItemColorProperty, value);
    }

    public static readonly BindableProperty ItemColorProperty =
        BindableProperty.Create(nameof(ItemColor), typeof(Color), typeof(Line));
}