using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts
{
    public partial class App : Application
    {

        public static string FilePath;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactPage());
        }

        // Qui ho aggiunto un costruttore 
        public App(string filePath)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ContactPage());

            FilePath = filePath;
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
