using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class MenteeConnectPageViewModel : ViewModelBase
    {
        public MenteeConnectPageViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "Connect";
        }
    }
}
