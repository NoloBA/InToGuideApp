using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class WelcomePageViewModel : ViewModelBase
    {
        public WelcomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Welcome";

        }
        private DelegateCommand _menteeCommand;
        public DelegateCommand MenteeCommand =>
            _menteeCommand ?? (_menteeCommand = new DelegateCommand(ExecuteMenteeCommand));

        private async void ExecuteMenteeCommand()
        {

            await NavigationService.NavigateAsync("MenteeCreateAccountPage");



        }

        private DelegateCommand _mentorCommand;
        public DelegateCommand MentorCommand =>
            _mentorCommand ?? (_mentorCommand = new DelegateCommand(ExecuteMentorCommand));

        private async void ExecuteMentorCommand()
        {
            await NavigationService.NavigateAsync("MentorCreateAccountPage");


        }
    }
}
