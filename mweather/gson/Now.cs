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
   public class Now
    {
        [SerializedName(Value = "tmp")]
        public string Tempterature { get; set; }

        [SerializedName(Value = "cond_txt")]
        public string Info { get; set; }
    }
}