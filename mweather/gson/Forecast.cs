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
    public class Forecast
    {
        public string Date { get; set; }

        [SerializedName(Value = "tmp_max")]
        public string Tempterature_max { get; set; }

        [SerializedName(Value = "tmp_min")]
        public string Tempterature_min { get; set; }

        [SerializedName(Value = "cond_txt_d")]
        public string Info { get; set; }
    }
}