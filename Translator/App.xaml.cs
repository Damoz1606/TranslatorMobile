using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Translator.Services;
using Translator.Views;
using System.IO;

namespace Translator
{
    public partial class App : Application
    {
        private static Mock_DataStore database;
        public App()
        {
            InitializeComponent();

            //DependencyService.Register<Mock_DataStore>();
            MainPage = new AppShell();
        }

        public static Mock_DataStore Database
        {
            get
            {
                if (database == null)
                {
                    database = new Mock_DataStore(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Translator.db3"));
                }
                return database;
            }
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
