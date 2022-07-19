using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class ForgotPasswordPageViewModel :ViewModelBase
    {
        public ForgotPasswordPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Forgot Password Page";
        }

        
    }
}
