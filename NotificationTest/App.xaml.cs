using Plugin.LocalNotification;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotificationTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();


            // Local Notification tap event listener
            NotificationCenter.Current.NotificationTapped += OnLocalNotificationTapped;

        }

        private void OnLocalNotificationTapped(NotificationTappedEventArgs e)
        {

            Device.BeginInvokeOnMainThread(async () =>
            {
                await this.MainPage.DisplayAlert("NotificationTest",
                                                "Tapped",
                                                "OK");
            });
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
