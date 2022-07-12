using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class HelpAndSupportPageViewModel : ViewModelBase
    {
        public HelpAndSupportPageViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "Help And Support Page";
        }
    }
}
