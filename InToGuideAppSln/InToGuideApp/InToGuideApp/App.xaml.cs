using InToGuideApp.ViewModels;
using InToGuideApp.Views;
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
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MenteeProfilePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<StartPage, StartPageViewModel>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<IntroductionPage, IntroductionPageViewModel>();
            containerRegistry.RegisterForNavigation<WelcomePage, WelcomePageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<MenteeCreateAccountPage, MenteeCreateAccountPageViewModel>();
            containerRegistry.RegisterForNavigation<MentorCreateAccountPage, MentorCreateAccountPageViewModel>();
            containerRegistry.RegisterForNavigation<MenteeResourcesPage, MenteeResourcesPageViewModel>();
            containerRegistry.RegisterForNavigation<MentorResourcesPage, MentorResourcesPageViewModel>();
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
        }
    }
}
