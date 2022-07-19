using InToGuideWebAPI.Enum;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class MenteeCreateAccountPageViewModel : ViewModelBase
    {
        public MenteeCreateAccountPageViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "Mentee Create Account Page";
        }

        private DelegateCommand _createMenteeAccountCommand;
        public DelegateCommand CreateMenteeAccountCommand =>
            _createMenteeAccountCommand ?? (_createMenteeAccountCommand = new DelegateCommand(ExecuteCreateMenteeAccountCommand));

        async void ExecuteCreateMenteeAccountCommand()
        {
            await NavigationService.NavigateAsync("LoginPage");
            int AccountType = (int)AccountTypeEnum.Mentee;
        }
    }
}
