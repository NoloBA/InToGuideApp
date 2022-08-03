using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class IntroductionPageViewModel : ViewModelBase
    {
        public IntroductionPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Introduction";

        }
        private DelegateCommand _introductionCommand;
        public DelegateCommand IntroductionCommand =>
            _introductionCommand ?? (_introductionCommand = new DelegateCommand(ExecuteIntroductionCommand));

        private async void ExecuteIntroductionCommand()
        {
            await NavigationService.NavigateAsync("WelcomePage");

        }
    }
}
