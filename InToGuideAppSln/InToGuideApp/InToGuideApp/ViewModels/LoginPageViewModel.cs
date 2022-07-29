using InToGuideApp.Helpers;
using InToGuideApp.Helpers.Validations.Rules;
using InToGuideApp.Services.Interfaces;
using InToGuideApp.Validations;
using InToGuideApp.Views.Dialogs;
using InToGuideWebAPI.Enum;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.CommunityToolkit.UI.Views;

namespace InToGuideApp.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private IAuthentication _authenticationService;
        private IDialogService _dialogService;
        private IEventAggregator _eventAggregator;

        private ValidatableObject<string> _emailAddress;
        public ValidatableObject<string> EmailAddress
        {
            get { return _emailAddress; }
            set { SetProperty(ref _emailAddress, value); }
        }

        private ValidatableObject<string> _password;
        public ValidatableObject<string> Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

       

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));

        private async void ExecuteLoginCommand()
        {
            // Do Login Authentication Stuff - check whether user exists and check username and password
            
            try
            {
                MainState = LayoutState.Loading;

                if (ValidateLoginData())
                {
                    var user = await _authenticationService.Authenticate(EmailAddress.Value, Password.Value);
                    if (user)
                    {
                        ClearAuthData();

                        await NavigationService.NavigateAsync("MentorTabbedPage");
                        //if (AccountTypeEnum.Mentor)
                        //{
                        //    await NavigationService.NavigateAsync("MentorTabbedPage");
                        //}
                        //else if (AccountTypeEnum == 2)
                        //{
                        //    await NavigationService.NavigateAsync("MenteeTabbedPage");
                        //}

                    }
                    else
                    {
                        var param = new DialogParameters()
                    {
                        {"message", Constants.Errors.WrongEmailOrPinError }
                    };
                        _dialogService.ShowDialog(nameof(ErrorDialog), param);
                    }
                }
            }
            catch(Exception ex)
            {
                var param = new DialogParameters()
                {
                    {"message",Constants.Errors.GeneralError }
                };
                _dialogService.ShowDialog(nameof(ErrorDialog), param);
            }
            finally
            {
                MainState = LayoutState.None;
            }
           

        }

        private DelegateCommand<string> _validateCommand;
        public DelegateCommand<string> ValidateCommand =>
            _validateCommand ?? (_validateCommand = new DelegateCommand<string>(ExecuteValidateCommand));

        private void ExecuteValidateCommand(string field)
        {
            switch (field)
            {
                case "email": EmailAddress.Validate(); break;
                case "pin": Password.Validate(); break;
            }
        }

        private DelegateCommand _forgotPasswordCommand;
        public DelegateCommand ForgotPasswordCommand =>
            _forgotPasswordCommand ?? (_forgotPasswordCommand = new DelegateCommand(ExecuteForgotPasswordCommand));

        async void ExecuteForgotPasswordCommand()
        {
            await NavigationService.NavigateAsync("ForgotPasswordPage");
        }

        private DelegateCommand _switchToSignUpCommand;
        public DelegateCommand SwitchToSignUpCommand =>
             _switchToSignUpCommand ?? (_switchToSignUpCommand = new DelegateCommand(ExecuteSwitchToSignUpCommand));

        private async void ExecuteSwitchToSignUpCommand()
        {
            await NavigationService.NavigateAsync("WelcomePage");
        }


        public LoginPageViewModel(INavigationService navigationService, IDialogService dialogService,
           IEventAggregator eventAggregator, IAuthentication authentication) : base(navigationService)
        {
            _dialogService = dialogService;
            _eventAggregator = eventAggregator;

            _authenticationService = authentication;

            AddValidations();

        }


        public override void Initialize(INavigationParameters parameters)
        {
            Title = "Login Page";
        }

        private void AddValidations()
        {
            EmailAddress = new ValidatableObject<string>();
            Password = new ValidatableObject<string>();

            EmailAddress.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "An email address is required." });
            EmailAddress.Validations.Add(new IsEmailRule<string> { ValidationMessage = "Email format is incorrect." });
            Password.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A password is required." });
        }

        private bool ValidateLoginData()
        {
            EmailAddress.Validate(true);
            Password.Validate(true);

            if (EmailAddress.IsValid == false ||
                Password.IsValid == false)
                return false;
            return true;
        }

        private void ClearAuthData()
        {
            EmailAddress.Value = Password.Value = string.Empty;
        }
    }
}
