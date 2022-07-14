using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class AppearancePageViewModel : ViewModelBase
    {
        public AppearancePageViewModel(INavigationService navigationService)
          : base(navigationService)
        {
            Title = "Appearance Page";
        }
    }
}
