using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace com.peterboos.anht
{
    public static class Constants
    {
        public const string ListenConnectionString = "Endpoint=sb://boos-sandbox.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=pnTm2hyDHJd6pyd/bZQ7eEP08DVOFbz+Ru6qSs+WRfI=";
        public const string NotificationHubName = "pb-notify-hub-test";
    }
}