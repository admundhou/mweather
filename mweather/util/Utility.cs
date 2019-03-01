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
using mweather.db;
using mweather.gson;
using Org.Json;

namespace mweather.util
{
    public static class Utility
    {
        /// <summary>
        /// 返回省级数据
        /// </summary>
        /// <param name="respose"></param>
        /// <returns></returns>
        public static bool HandleProvinceResponse(string respose)
        {
            if (string.IsNullOrEmpty(respose))
            {
                try
                {
                    JSONArray allProvince = new JSONArray(respose);

                    for (int i = 0; i < allProvince.Length() - 1; i++)
                    {
                        var provinceObject = allProvince.GetJSONObject(i);
                        var province = new Province();
                        province.provinceName = provinceObject.GetString("name");
                        province.id = provinceObject.GetInt("id");
                        province.Save();
                        return true;
                    }
                }
                catch (JSONException e)
                {
                    e.PrintStackTrace();
                }
            }
            return false;
        }

        /// <summary>
        /// 返回市级数据
        /// </summary>
        /// <param name="respose"></param>
        /// <returns></returns>
        public static bool HandleCityResponse(string respose,int provinceId)
        {
            if (string.IsNullOrEmpty(respose))
            {
                try
                {
                    JSONArray allCity = new JSONArray(respose);

                    for (int i = 0; i < allCity.Length(); i++)
                    {
                        var CityObject = allCity.GetJSONObject(i);
                        var City = new City();
                        City.cityName = CityObject.GetString("name");
                        City.cityCode = CityObject.GetInt("id");
                        City.provinceId = provinceId;
                        City.Save();
                    }

                    return true;
                }
                catch (JSONException e)
                {
                    e.PrintStackTrace();
                }
            }
            return false;
        }

        /// <summary>
        /// 返回县级数据
        /// </summary>
        /// <param name="respose"></param>
        /// <returns></returns>
        public static bool HandleCountryResponse(string respose, int cityId)
        {
            if (string.IsNullOrEmpty(respose))
            {
                try
                {
                    JSONArray allCountry = new JSONArray(respose);

                    for (int i = 0; i < allCountry.Length(); i++)
                    {
                        var CountryObject = allCountry.GetJSONObject(i);
                        var country = new Country();
                        country.countryName = CountryObject.GetString("name");
                        country.cityId = CountryObject.GetInt("id");
                        country.weatherId = CountryObject.GetString("weather_id");
                        country.cityId = cityId;
                        country.Save();
                    }

                    return true;
                }
                catch (JSONException e)
                {
                    e.PrintStackTrace();
                }
            }
            return false;
        }

        /// <summary>
        /// 将返回的json数据解析成weather的实体类
        /// </summary>
        /// <param name="respose"></param>
        /// <returns></returns>
        public static Weather HandleWeatherResponse(string respose)
        {
            if (string.IsNullOrEmpty(respose))
            {
                try
                {
                    var jsonObject = new JSONObject(respose);
                    JSONArray jsonArray = jsonObject.GetJSONArray("HeWeather6");
                    var weatherContent = jsonArray.GetJSONObject(0).ToString();

                   

                }
                catch (JSONException e)
                {
                    e.PrintStackTrace();
                }
            }
        }
    }
}