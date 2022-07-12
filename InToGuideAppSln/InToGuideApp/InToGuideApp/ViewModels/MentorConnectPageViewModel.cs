using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class MentorConnectPageViewModel : ViewModelBase
    {
        public MentorConnectPageViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "Mentor Connect Page";
        }
    }
}
