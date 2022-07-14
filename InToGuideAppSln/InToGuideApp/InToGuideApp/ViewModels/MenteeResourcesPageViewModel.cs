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
    }
}
