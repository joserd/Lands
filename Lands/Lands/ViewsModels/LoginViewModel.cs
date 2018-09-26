using System;
using System.Collections.Generic;
using System.Text;


namespace Lands.ViewsModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    class LoginViewModel
    {
        #region properties
        public String Email

        {
            get;
            set;

        }

        public String Password

        {
            get;
            set;

        }

        public bool IsRunning
        {
            get;
            set;

        }

        public bool IsRemembered

        {
            get;
            set;

        }


        #endregion

        #region
        public ICommand LoginCommand

        {
            get
            {
                return new RelayCommand(Login);
            }
          

        }

        private async void Login()
        {
            if(string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "you must enter an email",
                    "Accept");
                return;

            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "you must enter a Password",
                    "Accept");
                return;

            }

        }

        #endregion

        #region Constructors

        public LoginViewModel()
        {

            this.IsRemembered = true;
        }

        #endregion

       
       
    }
}
