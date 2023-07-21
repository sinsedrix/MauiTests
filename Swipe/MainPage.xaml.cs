using Swipe.ViewModels;
using System.Numerics;

namespace Swipe
{
    public partial class MainPage : ContentPage
    {
        MainVm Vm => BindingContext as MainVm;

        public MainPage(MainVm vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private async void ClickGestureRecognizer_Clicked(object sender, EventArgs e)
        {
            if (sender is SwipeView sv)
            {
                sv.Open(OpenSwipeItem.RightItems);
                Color orig = LblClick.TextColor;
                LblClick.TextColor = Colors.Green;
                await Task.Delay(500);
                LblClick.TextColor = orig;
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            if (sender is SwipeView sv)
            {
                sv.Open(OpenSwipeItem.RightItems);
                Color orig = LblTap.TextColor;
                LblTap.TextColor = Colors.Green;
                await Task.Delay(500);
                LblTap.TextColor = orig;
            }
        }

        private async void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            if ((sender as DragGestureRecognizer).Parent is SwipeView sv)
            {
                sv.Open(OpenSwipeItem.RightItems);
                Color orig = LblDrag.TextColor;
                LblDrag.TextColor = Colors.Green;
                await Task.Delay(500);
                LblDrag.TextColor = orig;
            }
        }

        private void BtnOpen_Clicked(object sender, EventArgs e)
        {
            sv2.Open(OpenSwipeItem.RightItems);
        }

        private void BtnClose_Clicked(object sender, EventArgs e)
        {
            sv2.Close();
        }
    }
}