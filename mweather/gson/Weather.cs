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
   public  class Weather
    {
        public string Status { get; set; }

        public Basic Basic { get; set; }

        public Now Now { get; set; }

        [SerializedName(Value = "lifestyle")]
        public List<Suggestion> Suggestions { get; set; }

        [SerializedName(Value = "daily_forecast")]
        public List<Forecast> Forecasts { get; set; }

        public Update Update { get; set; }
    }

    public class Update
    {
        public string Loc { get; set; }
    }
}