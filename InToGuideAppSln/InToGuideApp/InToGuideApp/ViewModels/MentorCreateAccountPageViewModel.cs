using InToGuideWebAPI.Enum;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class MentorCreateAccountPageViewModel : ViewModelBase
    {
        public MentorCreateAccountPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Mentor Create Account Page";
        }

        private DelegateCommand _createMentorAccountCommand;
        public DelegateCommand CreateMentorAccountCommand =>
            _createMentorAccountCommand ?? (_createMentorAccountCommand = new DelegateCommand(ExecuteCreateMentorAccountCommand));

        async void ExecuteCreateMentorAccountCommand()
        {
            await NavigationService.NavigateAsync("LoginPage");
            int AccountType = (int)AccountTypeEnum.Mentor;
        }
    }
}
