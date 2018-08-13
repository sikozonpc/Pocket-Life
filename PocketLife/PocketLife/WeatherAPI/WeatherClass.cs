using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using PocketLife.WeatherAPI;

namespace PocketLife
{
    public class WeatherClass
    {
        const string API_KEY = "3cfe7ad7612a67aaecfada45e053e034";
        string API_CALL = "http://api.openweathermap.org/data/2.5/weather?q=";
        // TEST -> http://api.openweathermap.org/data/2.5/weather?q=Lisbon&APPID=3cfe7ad7612a67aaecfada45e053e034

        public WeatherJsonModel.Root getWeatherData(string cityName)
        {
            using (WebClient web = new WebClient())
            {
                string url = API_CALL + cityName + "&APPID=3cfe7ad7612a67aaecfada45e053e034";

                //TODO - Try Catch when city/country name doesn't exist 
                var json = web.DownloadString(url);


                var result = JsonConvert.DeserializeObject<WeatherJsonModel.Root>(json);
                WeatherJsonModel.Root output = result;

                return output;
            }
        }

        public WeatherModel convertData(WeatherJsonModel.Root rootModel)
        {
            WeatherModel model = new WeatherModel();

            model.City = rootModel.name;
            model.Country = rootModel.sys.country;
            model.CurrentTemperature = rootModel.main.temp - 272.15;

            List<WeatherJsonModel.weather> tempList = rootModel.weather;
            foreach(var i in tempList)
            {
                // model.Description = i.description;
                model.Description = i.main;
            }

            model.Humidity = rootModel.main.humidity;
            model.Pressure = rootModel.main.pressure;
            model.WindSpeed = rootModel.wind.speed;
            //TODO - calculate direction from the angle
            model.WindAngle = rootModel.wind.deg;
            model.Sunrise = UnixTimeStampToDateTime( rootModel.sys.sunrise);
            model.Sunset = UnixTimeStampToDateTime(rootModel.sys.sunset);

            return model;
        }
        /// <summary>
        /// Converts time from unix to human readable DateTime
        /// </summary>
        /// <param name="unixTimeStamp"> Time in unix since epoch</param>
        /// <returns></returns>
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }


    }
}
