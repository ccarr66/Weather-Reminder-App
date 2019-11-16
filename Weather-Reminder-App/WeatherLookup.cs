using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Reminder_App
{
    static class WeatherLookup
    {
        private static string key = "7451d294ebca4b6a4c5fd77a6ba8e60f";
        public static OpenWeatherAPI.Query weatherInfo;

        public static bool validCity(string city)
        {
            weatherInfo = new OpenWeatherAPI.Query(key, city);
            return weatherInfo.ValidRequest;
        }

        public static bool update()
        {
            weatherInfo = new OpenWeatherAPI.Query(key, User.UserLocation);
            return weatherInfo.ValidRequest;
        }

    }

}
