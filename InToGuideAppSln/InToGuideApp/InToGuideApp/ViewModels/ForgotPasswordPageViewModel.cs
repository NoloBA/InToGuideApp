using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.CommunityToolkit.UI.Views;

namespace InToGuideApp.ViewModels
{
    public class ForgotPasswordPageViewModel :ViewModelBase
    {
        public ForgotPasswordPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Forgot Password Page";
        }

        private DelegateCommand _forgotPasswordCommand;
        public DelegateCommand ForgotPasswordCommand =>
            _forgotPasswordCommand ?? (_forgotPasswordCommand = new DelegateCommand(ExecuteForgotPasswordCommand));

        void ExecuteForgotPasswordCommand()
        {
            MainState = LayoutState.Custom;
        }
        
    }
}
