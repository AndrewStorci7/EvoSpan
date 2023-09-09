using EvoSpan.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EvoSpan
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            /// Home Content Page
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

            /// Add New Activity Content Page
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));

            /// Browse You Active Activities Content Page
            Routing.RegisterRoute(nameof(Activities), typeof(Activities));

            /// Settings Content Page
            Routing.RegisterRoute(nameof(Settings), typeof(Settings));
        }

    }
}
