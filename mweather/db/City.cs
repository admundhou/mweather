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
using Org.Litepal.Crud;

namespace mweather.db
{
    public class City : DataSupport
    {
        public int id { get; set; }
        public string cityName { get; set; }
        public int cityCode { get; set; }
        public int provinceId { get; set; }
    }
}