using algorand_mobile.Services;
using algorand_mobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace algorand_mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new AlgorandPayments.Views.HomePage());
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
