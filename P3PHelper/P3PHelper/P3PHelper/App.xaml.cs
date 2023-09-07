using P3PHelper.Models;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace P3PHelper
{
    public partial class App : Application
    {
        public static AppDatabase Database { get; private set; }

        public App()
        {
            InitializeComponent();

            //string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), 
            //    "appdatabase.db3");
            //Database = new AppDatabase(dbPath);

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
