using InToGuideApp.Services.Interfaces;
using InToGuideWebAPI.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Navigation.TabbedPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class MenteeDashboardPageViewModel : ViewModelBase
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
        public MenteeDashboardPageViewModel(INavigationService navigationService, IDataCache dataCache)
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
                WelcomeMessage = $"Welcome {LoggedInUser.FirstName} {LoggedInUser.LastName}";

            }

        }
        private DelegateCommand _settingsCommand;
        public DelegateCommand SettingsCommand =>
            _settingsCommand ?? (_settingsCommand = new DelegateCommand(ExecuteSettingsCommand));

        async void ExecuteSettingsCommand()
        {
            await NavigationService.NavigateAsync("SettingsPage");
        }
    }
}
