using System;
using System.Collections.Generic;
using Translator.ViewModels;
using Translator.Views;
using Xamarin.Forms;

namespace Translator
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Add_View), typeof(Add_View));
            Routing.RegisterRoute(nameof(Edit_View), typeof(Edit_View));
            Routing.RegisterRoute(nameof(Delete_View), typeof(Delete_View));
            Routing.RegisterRoute(nameof(List_View), typeof(List_View));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
