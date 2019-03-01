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
using Com.Google.Gson.Annotations;
namespace mweather.gson
{
    public  class Basic
    {
        [SerializedName(Value = "location")]
        public string BasicId { get; set; }

        [SerializedName(Value = "cid")]
        public string WeatherId { get; set; }
    }
}