using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NotificationTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            NotificationTest.Notification.Notification_Show(u_BargeCount: 0, u_Repeat: Plugin.LocalNotification.NotificationRepeat.No);
        }
    }
}
