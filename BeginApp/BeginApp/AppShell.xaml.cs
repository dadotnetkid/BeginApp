using System;
using System.Collections.Generic;
using BeginApp.ViewModels;
using BeginApp.Views;
using Xamarin.Forms;

namespace BeginApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
