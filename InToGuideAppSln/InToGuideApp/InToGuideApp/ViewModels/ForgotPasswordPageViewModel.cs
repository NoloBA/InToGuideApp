using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;

namespace InToGuideApp.ViewModels
{
    public class ForgotPasswordPageViewModel :ViewModelBase
    {
        public ForgotPasswordPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Forgot Password";
        }

        private DelegateCommand _forgotPasswordCommand;
        public DelegateCommand ForgotPasswordCommand =>
            _forgotPasswordCommand ?? (_forgotPasswordCommand = new DelegateCommand(ExecuteForgotPasswordCommand));

        async void ExecuteForgotPasswordCommand()
        {

            MainState = LayoutState.Saving;
            await Task.Delay(10000);
            MainState = LayoutState.None;
        }

    }
}
