using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using flyoutapp1.Services;
using flyoutapp1.Views;

namespace flyoutapp1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
