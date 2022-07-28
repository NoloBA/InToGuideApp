using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class SettingsPageViewModel : ViewModelBase
    {
        public SettingsPageViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "Settings";
        }

       

        private DelegateCommand _mentorProfileCommand;
        public DelegateCommand MentorProfileCommand =>
            _mentorProfileCommand ?? (_mentorProfileCommand = new DelegateCommand(ExecuteMentorProfileCommand));

        async void ExecuteMentorProfileCommand()
        {
            await NavigationService.NavigateAsync("ProfilePage"); //how do i redirect mentee/mmentor profile to only profile
        }

        private DelegateCommand _appearanceCommand;
        public DelegateCommand AppearanceCommand =>
            _appearanceCommand ?? (_appearanceCommand = new DelegateCommand(ExecuteAppearanceCommand));

        async void ExecuteAppearanceCommand()
        {
            await NavigationService.NavigateAsync("AppearancePage");
        }

        private DelegateCommand _notificationsCommand;
        public DelegateCommand NotificationsCommand =>
            _notificationsCommand ?? (_notificationsCommand = new DelegateCommand(ExecuteNotificationsCommand));

        async void ExecuteNotificationsCommand()
        {
            await NavigationService.NavigateAsync("NotificationsPage");
        }

        private DelegateCommand _helpAndSupportCommand;
        public DelegateCommand HelpAndSupportCommand =>
            _helpAndSupportCommand ?? (_helpAndSupportCommand = new DelegateCommand(ExecuteHelpAndSupportCommand));

        async void ExecuteHelpAndSupportCommand()
        {
            await NavigationService.NavigateAsync("HelpAndSupportPage");
        }

        private DelegateCommand _aboutCommand;
        public DelegateCommand AboutCommand =>
            _aboutCommand ?? (_aboutCommand = new DelegateCommand(ExecuteAboutCommand));

        private DelegateCommand _reviewCommand;
        public DelegateCommand ReviewCommand =>
            _reviewCommand ?? (_reviewCommand = new DelegateCommand(ExecuteReviewCommand));

        async void ExecuteReviewCommand()
        {
            await NavigationService.NavigateAsync("ReviewPage");
        }

        async void ExecuteAboutCommand()
        {
            await NavigationService.NavigateAsync("AboutPage");
        }

        private DelegateCommand _logoutCommand;
        public DelegateCommand LogoutCommand =>
            _logoutCommand ?? (_logoutCommand = new DelegateCommand(ExecuteLogoutCommand));

        void ExecuteLogoutCommand()
        {
            //Do logout code stuff here 
        }
    }
}
