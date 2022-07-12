using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class MenteeProfilePageViewModel : ViewModelBase
    {
        public MenteeProfilePageViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "Mentee Profile Page";
        }
    }
}
