using MathApp.Services;
using MathApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MathApp
{
    public partial class App : Application
    {
        public static readonly IRestService RestServiceInstance;

        static App()
        {
            RestServiceInstance = new RestService();
        }

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
