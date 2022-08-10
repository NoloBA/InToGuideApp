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
    public class PostMatchMentorDashboardViewModel : ViewModelBase
    {
        private IDataCache _dataCache;

        private User _loggedInUser;
        public User LoggedInUser
        {
            get { return _loggedInUser; }
            set { SetProperty(ref _loggedInUser, value); }
        }

        private string _welcomeMessage;
        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set { SetProperty(ref _welcomeMessage, value); }
        }
        private string _qualification;
        public string Qualification
        {
            get { return _qualification; }
            set { SetProperty(ref _qualification, value); }
        }

        private string _institution;
        public string Institution
        {
            get { return _institution; }
            set { SetProperty(ref _institution, value); }
        }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }

        public PostMatchMentorDashboardViewModel(INavigationService navigationService, IDataCache dataCache)
            : base(navigationService)
        {
           _dataCache = dataCache;
        }
        public override void Initialize(INavigationParameters parameters)
        {
            Title = "Dashboard";

            LoggedInUser = _dataCache.AuthenticatedUser;


            if (LoggedInUser != null)
            {
                WelcomeMessage = $"Welcome {LoggedInUser.FirstName} {LoggedInUser.LastName}!";
                Qualification = "BSc Chemical Science";
                Institution = "Stellenbosch University";
                FullName = "Jack Sparrow";

            }

        }

        private DelegateCommand _settingsCommand;
        public DelegateCommand SettingsCommand =>
            _settingsCommand ?? (_settingsCommand = new DelegateCommand(ExecuteSettingsCommand));

        async void ExecuteSettingsCommand()
        {
            await NavigationService.NavigateAsync("SettingsPage");
        }

        private DelegateCommand _templateCommand;
        public DelegateCommand TemlateCommand =>
            _templateCommand ?? (_templateCommand = new DelegateCommand(ExecuteTemplateCommand));

        async void ExecuteTemplateCommand()
        {
            await NavigationService.NavigateAsync(""); //template link added here
        }

        private DelegateCommand _certificateCommand;
        public DelegateCommand CertificateCommand =>
            _certificateCommand ?? (_certificateCommand = new DelegateCommand(ExecuteCertificateCommand));

        async void ExecuteCertificateCommand()
        {
            await NavigationService.NavigateAsync(""); //mentor certificate link added here
        }
    }
}
