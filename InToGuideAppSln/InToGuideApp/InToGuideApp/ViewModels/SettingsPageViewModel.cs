using InToGuideApp.Services.Interfaces;
using InToGuideWebAPI.Models;
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

        private IDataCache _dataCache;

        private User _loggedInUser;
        public User LoggedInUser
        {
            get { return _loggedInUser; }
            set { SetProperty(ref _loggedInUser, value); }
        }
        public SettingsPageViewModel(INavigationService navigationService, IDataCache dataCache)
           : base(navigationService)
        {
            _dataCache = dataCache;
           
        }

       

        private DelegateCommand _profileCommand;
        public DelegateCommand ProfileCommand =>
            _profileCommand ?? (_profileCommand = new DelegateCommand(ExecuteProfileCommand));

        async void ExecuteProfileCommand()
        {
            LoggedInUser = _dataCache.AuthenticatedUser;

            if (LoggedInUser != null)
            {
                if (LoggedInUser.AccountType == 1) //if mentor
                {
                    await NavigationService.NavigateAsync("MentorProfilePage"); //redirects to mentor profile page
                }
                else if (LoggedInUser.AccountType == 2) //if mentee
                {
                    await NavigationService.NavigateAsync("MenteeProfilePage"); //redirects to mentee profile page
                }
            }
            //await NavigationService.NavigateAsync("ProfilePage"); //how do i redirect mentee/mmentor profile to only profile
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

        public override void Initialize(INavigationParameters parameters)
        {
            Title = "Menu";
        }

    }
}
