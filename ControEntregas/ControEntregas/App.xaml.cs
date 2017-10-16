using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ControEntregas
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();
            //If user is logged
            if (App.Current.Properties.ContainsKey("logged") && ((bool)App.Current.Properties["logged"]))
            {
                MainPage = new NavigationPage(new Menu())
                {
                    BarBackgroundColor = Color.FromHex("#175081"),
                    BarTextColor = Color.White,
                };
            }
            else
            {
                MainPage = new NavigationPage(new ControEntregas.MainPage())
                {
                    BarBackgroundColor = Color.FromHex("#175081"),
                    BarTextColor = Color.White,
                };
            }
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
