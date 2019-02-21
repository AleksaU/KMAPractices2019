using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LoginApplication.Annotations;
using LoginApplication.Tools;
using LoginApplication.Tools.Managers;
using Test.Misc;

namespace LoginApplication
{
    class SignInViewModel : INotifyPropertyChanged
    {
        #region Fields
        private User _user;

        private string _login;
        private string _password = "";

        private ICommand _signInCommand;

        private ICommand _signUpCommand;

        #endregion

        #region Properties
        public ICommand SignInCommand => _signInCommand ?? (_signInCommand = new RelayCommand<object>(o => SignIn(), o => !string.IsNullOrEmpty(_password) && !string.IsNullOrEmpty(_login)));
        public ICommand SignUpCommand => _signUpCommand ?? (_signUpCommand = new RelayCommand<object>(o => { NavigateManager.Instance.Navigate(ViewType.SignUp); }));

        public string Login
        {
            get { return _login; }
            set
            {
                _login = "";
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == ' ')
                    {
                        continue;
                    }
                    _login = _login + value[i];
                }
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                string asterics = "";
                for (int i = 0; i < _password.Length; i++)
                {
                    asterics += '*';
                }
                return asterics;
            }
            set { _password = value; }
        }

        #endregion

        #region Constructors
        public SignInViewModel()
        {
            this._user = new User();
        }
        #endregion

        #region Methods

        private async void SignIn()
        {
            LoaderManager.Instance.ShowLoader();
            await Task.Run(() => Thread.Sleep(5000));
            LoaderManager.Instance.HideLoader();
            MessageBox.Show("User sign in succesfully");
        }
        #endregion

        #region OnProperetyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
