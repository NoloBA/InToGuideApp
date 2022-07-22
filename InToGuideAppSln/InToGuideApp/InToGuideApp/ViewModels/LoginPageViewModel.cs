using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {

            Title = "Login Page";
        }

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));

        private async void ExecuteLoginCommand()
        {
            // Do Login Authentication Stuff - check whether user exists and check username and password


            await NavigationService.NavigateAsync("LandingPage");

        }

        private DelegateCommand _createAccountCommand;
        public DelegateCommand CreateAccountCommand =>
             _createAccountCommand ?? (_createAccountCommand = new DelegateCommand(ExecuteCreateAccountCommand));

        private async void ExecuteCreateAccountCommand()
        {
            await NavigationService.NavigateAsync("WelcomePage");
        }

        private DelegateCommand _forgotPasswordCommand;
        public DelegateCommand ForgotPasswordCommand =>
            _forgotPasswordCommand ?? (_forgotPasswordCommand = new DelegateCommand(ExecuteForgotPasswordCommand));

        async void ExecuteForgotPasswordCommand()
        {
            await NavigationService.NavigateAsync("ForgotPasswordPage");
        }
        
    }
}
