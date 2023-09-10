using EvoSpan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EvoSpan.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            var vm = new LoginViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid parameter", "OK");
            
            InitializeComponent();

            Id.Completed += (object obj, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object obj, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };
        }
    }
}