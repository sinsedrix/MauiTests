﻿namespace StatusPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainVm vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }

}
