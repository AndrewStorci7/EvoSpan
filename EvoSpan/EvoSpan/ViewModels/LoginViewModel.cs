using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace EvoSpan.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        public string _id;

        [ObservableProperty]
        public string _password;

        [ObservableProperty]
        public string _idManagment;

        public async void Login()
        {

        }
    }
}
