using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PCALC.Views;

namespace PCALC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PageOne();
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
