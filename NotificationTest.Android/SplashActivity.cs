using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationTest.Droid
{
    [Activity(Label = "NotificationTest", Icon = "@drawable/Prizvarat", Theme = "@style/SplashTheme", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);

            // Test s notifikaciami.
            var mainIntent = new Intent(Application.Context, typeof(MainActivity));
            if (Intent.Extras != null)
            {
                mainIntent.PutExtras(Intent.Extras);
            }
            mainIntent.SetFlags(ActivityFlags.SingleTop);
            StartActivity(mainIntent);

        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();

            var mainIntent = new Intent(Application.Context, typeof(MainActivity));
            if (Intent.Extras != null)
            {
                mainIntent.PutExtras(Intent.Extras);
            }
            StartActivity(mainIntent);

            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        // Simulates background work that happens behind the splash screen
        async void SimulateStartup()
        {
            await Task.Delay(1500); // Simulate a bit of startup work.
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

    }
}