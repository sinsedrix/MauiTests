using System.Collections;
using System.Windows.Input;

namespace PickerItem;

public partial class PickerItem : ContentView
{
    public ImageSource Icon
    {
        get => (ImageSource)GetValue(IconProperty);
        set { SetValue(IconProperty, value); }
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set { SetValue(TextProperty, value); }
    }

    public IList ItemsSource
    {
        get => (IList)GetValue(ItemsSourceProperty);
        set { SetValue (ItemsSourceProperty, value); }
    }

    public object SelectedItem
    {
        get => GetValue(SelectedItemProperty);
        set { SetValue(SelectedItemProperty, value); }
    }

    public BindingBase ItemDisplayBinding 
    {
        get => InnerPicker.ItemDisplayBinding;
        set => InnerPicker.ItemDisplayBinding = value; 
    }

    public PickerItem()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(PickerItem));

    public static readonly BindableProperty IconProperty =
     BindableProperty.Create(nameof(Icon), typeof(ImageSource), typeof(PickerItem));


    public static readonly BindableProperty ItemsSourceProperty =
        BindableProperty.Create(nameof(ItemsSource), typeof(IList), typeof(PickerItem));

    public static readonly BindableProperty SelectedItemProperty =
     BindableProperty.Create(nameof(SelectedItem), typeof(object), typeof(PickerItem));

}