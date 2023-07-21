using TransBinding.ViewModels;

namespace TransBinding;

public partial class MainPage : ContentPage
{
    public MainVm Vm => BindingContext as MainVm;

    public MainPage(MainVm vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var waitTask = Task.Run(async () =>
        {
            while (!selector.IsReady) await Task.Delay(25);
        });

        if (waitTask != await Task.WhenAny(waitTask, Task.Delay(-1)))
            throw new TimeoutException();
        
        selector.ItemSize = Vm.SelectedSize;
        selector.ItemSelectedCommand = Vm.SelectItemCommand;
    }
}