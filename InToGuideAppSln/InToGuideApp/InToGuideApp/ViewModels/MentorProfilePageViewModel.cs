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
    public class MentorProfilePageViewModel : ViewModelBase
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

        private string _company;
        public string Company
        {
            get { return _company; }
            set { SetProperty(ref _company, value); }
        }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }

        private string _idNumber;
        public string IdNumber
        {
            get { return _idNumber; }
            set { SetProperty(ref _idNumber, value); }
        }

        private string _emailAddress;
        public string EmailAddress
        {
            get { return _emailAddress; }
            set { SetProperty(ref _emailAddress, value); }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }

        private string _province;
        public string Province
        {
            get { return _province; }
            set { SetProperty(ref _province, value); }
        }

        private string _leisureActivities;
        public string LeisureActivities
        {
            get { return _leisureActivities; }
            set { SetProperty(ref _leisureActivities, value); }
        }
        public MentorProfilePageViewModel(INavigationService navigationService, IDataCache dataCache)
            : base(navigationService)
        {
            _dataCache = dataCache;
        }

        public override void Initialize(INavigationParameters parameters)
        {
            Title = "Profile";

            LoggedInUser = _dataCache.AuthenticatedUser;

            if (LoggedInUser != null)
            {
                Profession = LoggedInUser.Profession;
                Company = LoggedInUser.Company;
                FullName = $"{LoggedInUser.FirstName} {LoggedInUser.LastName}";
                IdNumber = LoggedInUser.IdNumber;
                EmailAddress = LoggedInUser.EmailAddress;
                PhoneNumber = LoggedInUser.PhoneNumber;
                City = LoggedInUser.City;
                Province = LoggedInUser.Province;
                LeisureActivities = LoggedInUser.Hobbies;

            }
        }

        private DelegateCommand _changePasswordCommand;
        public DelegateCommand ChangePasswordCommand =>
            _changePasswordCommand ?? (_changePasswordCommand = new DelegateCommand(ExecuteChangePasswordCommand));

        async void ExecuteChangePasswordCommand()
        {
            await NavigationService.NavigateAsync("ResetPasswordPage");
        }
    }
}
