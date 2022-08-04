using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class MenteeResourcesPageViewModel : ViewModelBase
    {
        public MenteeResourcesPageViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "Resources";
        }

        private DelegateCommand _certificateCommand;
        public DelegateCommand CertificateCommand =>
            _certificateCommand ?? (_certificateCommand = new DelegateCommand(ExecuteCertificateCommand));

        async void ExecuteCertificateCommand()
        {
            await NavigationService.NavigateAsync(""); // mentee certificate link added here
        }
    }
}
