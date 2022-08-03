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
    public class MentorProfileViewModel : ViewModelBase
    {
        private IDataCache _dataCache;

        private User _loggedInUser;
        public User LoggedInUser
        {
            get { return _loggedInUser; }
            set { SetProperty(ref _loggedInUser, value); }
        }

        private string _profession;
        public string Profession
        {
            get { return _profession; }
            set { SetProperty(ref _profession, value); }
        }
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }
        private string _location;
        public string Location
        {
            get { return _location; }
            set { SetProperty(ref _location, value); }
        }
        private string _emailAddress;
        public string EmailAddress
        {
            get { return _emailAddress; }
            set { SetProperty(ref _emailAddress, value); }
        }
        public MentorProfileViewModel(INavigationService navigationService, IDataCache dataCache)
           : base(navigationService)
        {
            _dataCache = dataCache; 
        }

        public override void Initialize(INavigationParameters parameters)
        {
            Title = "Profile View";

            LoggedInUser = _dataCache.AuthenticatedUser;

            if (LoggedInUser.AccountType == 1)
            {
                FullName = $"{LoggedInUser.FirstName} {LoggedInUser.LastName}";
                Profession = LoggedInUser.Profession;
                Location = $"{LoggedInUser.City}, {LoggedInUser.Province}";
                EmailAddress = LoggedInUser.EmailAddress;
            }
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
