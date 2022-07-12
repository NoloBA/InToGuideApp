using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class MenteeDashboardPageViewModel : ViewModelBase
    {
        public MenteeDashboardPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Mentee Dashboard Page";
        }
    }
}
