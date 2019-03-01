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
using Okhttp3;

namespace mweather.util
{
    public static  class HttpUtil
    {
        public static void sendOkHttpRequests(string address,Okhttp3.ICallback callbck)
        {
            var client = new OkHttpClient();
            Okhttp3.Request requests = new Request.Builder().Url(address).Build();
            requests.Url();
            client.NewCall(requests).Enqueue(callbck);
        }
    }
}