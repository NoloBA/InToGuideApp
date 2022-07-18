using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class MentorProfileViewModel : ViewModelBase
    {
        public MentorProfileViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "Mentor Profile View";
        }

        private DelegateCommand _settingsCommand;
        public DelegateCommand SettingsCommand =>
            _settingsCommand ?? (_settingsCommand = new DelegateCommand(ExecuteSettingsCommand));

        async void ExecuteSettingsCommand()
        {
            await NavigationService.NavigateAsync("SettingsPage");
        }

        private DelegateCommand _reviewCommand;
        public DelegateCommand ReviewCommand =>
            _reviewCommand ?? (_reviewCommand = new DelegateCommand(ExecuteReviewCommand));

        async void ExecuteReviewCommand()
        {
            await NavigationService.NavigateAsync("ReviewPage");
        }
    }
}
