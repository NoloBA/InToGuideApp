using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class MentorProfileViewModel : ViewModelBase
    {
        public MentorProfileViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "Mentor Profile View";
        }
    }
}
