﻿using System;
using System.IO;
using Moga_Stefan_Lab10.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Moga_Stefan_Lab10
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        
        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListEntryPage());
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
