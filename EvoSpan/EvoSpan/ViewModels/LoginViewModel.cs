using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace EvoSpan.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string id;
        private string Id
        {
            get { return id; }
            set
            {
                id = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        public void OnSubmit()
        {
            /// <summary>
            /// TODO:
            /// Delegate password and username control to the server 
            /// </summary>
            /// 
            /// <summary>
            /// The code below is only for test
            /// </summary>
            if (id != "andrea.storci" || password != "admin")
                DisplayInvalidLoginPrompt();
            else
                Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
