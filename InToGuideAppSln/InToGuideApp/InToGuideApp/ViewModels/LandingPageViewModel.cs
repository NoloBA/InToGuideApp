using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InToGuideApp.ViewModels
{
    public class LandingPageViewModel : ViewModelBase
    {
        public LandingPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
