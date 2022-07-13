using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class MentorDashboardPageViewModel : ViewModelBase
    {
        public MentorDashboardPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Dashbord";
        }
    }
}
