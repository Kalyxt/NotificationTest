using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationTest
{
    public static class Notification
    {

        public static void Notification_Show(int u_BargeCount, NotificationRepeat u_Repeat, string Image = default)
        {

            var request = new NotificationRequest
            {
                NotificationId = 100,
                Title = "Title",
                Description = "Description",
                BadgeNumber = u_BargeCount,
                Repeats = u_Repeat,
                Sound = null,
                Android =
                {
                    IconName = Image,
                },
            };

            NotificationCenter.Current.Show(request);
        }



    }
}
