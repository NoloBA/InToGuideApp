using InToGuideApp.Services;
using InToGuideApp.Services.Interfaces;
using InToGuideApp.ViewModels;
using InToGuideApp.Views;
using InToGuideApp.Services.Core;
using InToGuideApp.Services.Interfaces;
using InToGuideApp.Views.Dialogs;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace InToGuideApp
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        

        protected override async void OnInitialized()
        {
            //licensing of syncfusion nuget package
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Njc2NDQxQDMyMzAyZTMyMmUzMEJNOHAxS2xuSUFCdVRBLytzbE1SdlM5QVBvdnlML2g0WGxsTllIMEtOVGs9");
            InitializeComponent();

            
            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<ICreateAccount, CreateAccountService>();
            containerRegistry.Register<IAuthentication, AuthenticationService>();

            containerRegistry.RegisterSingleton<IDataCache, InMemoryDataCache>();

            containerRegistry.Register<IAppConfiguration, AppConfigurationService>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<IntroductionPage, IntroductionPageViewModel>();
            containerRegistry.RegisterForNavigation<WelcomePage, WelcomePageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<MenteeCreateAccountPage, MenteeCreateAccountPageViewModel>();
            containerRegistry.RegisterForNavigation<MentorCreateAccountPage, MentorCreateAccountPageViewModel>();
            containerRegistry.RegisterForNavigation<MenteeResourcesPage, MenteeResourcesPageViewModel>();
            containerRegistry.RegisterForNavigation<MentorDashboardPage, MentorDashboardPageViewModel>();
            containerRegistry.RegisterForNavigation<MenteeDashboardPage, MenteeDashboardPageViewModel>();
            containerRegistry.RegisterForNavigation<MenteeConnectPage, MenteeConnectPageViewModel>();
            containerRegistry.RegisterForNavigation<MentorConnectPage, MentorConnectPageViewModel>();
            containerRegistry.RegisterForNavigation<MentorProfileView, MentorProfileViewModel>();
            containerRegistry.RegisterForNavigation<SettingsPage, SettingsPageViewModel>();
            containerRegistry.RegisterForNavigation<MentorProfilePage, MentorProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<MenteeProfilePage, MenteeProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<NotificationsPage, NotificationsPageViewModel>();
            containerRegistry.RegisterForNavigation<HelpAndSupportPage, HelpAndSupportPageViewModel>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutPageViewModel>();
            containerRegistry.RegisterForNavigation<AppearancePage, AppearancePageViewModel>();
            containerRegistry.RegisterForNavigation<MentorTabbedPage, MentorTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<MenteeTabbedPage, MenteeTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<ReviewPage, ReviewPageViewModel>();
            containerRegistry.RegisterForNavigation<ForgotPasswordPage, ForgotPasswordPageViewModel>();
            containerRegistry.RegisterForNavigation<ResetPasswordPage, ResetPasswordPageViewModel>();
            containerRegistry.RegisterForNavigation<Chat, ChatViewModel>();
            containerRegistry.Register<IChatService, ChatService>();

            containerRegistry.RegisterDialog<ErrorDialog, ErrorDialogViewModel>();
        }
    }
}
