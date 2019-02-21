using LoginApplication.Tools;
using LoginApplication.Tools.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Test.Misc;

namespace LoginApplication.ViewModels
{
    class SignUpViewModel
    {
        private ICommand checkUser;

        private ICommand _returnToSignInCommand;

        #region Properties
        public ICommand CheckUserCommand => checkUser ?? (checkUser = new RelayCommand<object>(o => CheckUser()));
        public ICommand ReturnToSignInCommand => _returnToSignInCommand ?? (_returnToSignInCommand = new RelayCommand<object>(o => NavigateManager.Instance.Navigate(ViewType.SignIn)));
        #endregion
        async void CheckUser()
        {
            LoaderManager.Instance.ShowLoader();
            await Task.Run(() => Thread.Sleep(5000));
            LoaderManager.Instance.HideLoader();
            MessageBox.Show("User is checked");


        }
    }
}
