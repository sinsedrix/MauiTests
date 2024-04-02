﻿namespace Modal
{
    public partial class App : Application
    {
        public static new App Current => (App)Application.Current;

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        public IServiceProvider Container { get; set; }
    }
}
