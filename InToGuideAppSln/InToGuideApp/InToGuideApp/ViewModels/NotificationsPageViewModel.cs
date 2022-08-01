using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class NotificationsPageViewModel : ViewModelBase
    {
        public NotificationsPageViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "Notifications";
        }

        
    }
}
