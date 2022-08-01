using Android.App;
using Android.Content;
using AndroidX.AppCompat.App;
using InToGuideApp.Views;
using System;
using System.Threading.Tasks;

namespace InToGuideApp.Droid
{
    [Activity(Theme = "@style/MainTheme.Splash",
              MainLauncher = true,
              NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        // Launches the startup task
        protected override async void OnResume()
        {
            base.OnResume();
            //StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            await SimulateStartup();
        }

         async Task SimulateStartup() 
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}
