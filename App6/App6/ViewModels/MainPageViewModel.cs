using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        private string _userName;
        private string _password;
        private Command _loginCommand;
        private bool isErrorLogin1;

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {

        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public Command LoginCommand
        {
            get => _loginCommand ?? (_loginCommand = new Command(GoToLoginAction));
        }

        public bool IsErrorLogin
        {
            get => isErrorLogin1; 
            set
            {
                isErrorLogin1 = value;
                OnPropertyChanged();
            }
        }

        private void GoToLoginAction()
        {
            IsErrorLogin = !(string.Equals(UserName, "Consuelo") && string.Equals(Password, "123"));
            if (!IsErrorLogin)
            {
                UserName = String.Empty;
                Password = String.Empty;
                Navigation.PushAsync(new PaginaInicio());

            }
        }
    }

}
