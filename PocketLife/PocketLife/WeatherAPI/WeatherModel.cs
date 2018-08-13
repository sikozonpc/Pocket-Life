using System;
using System.Collections.Generic;
using System.Text;

namespace PocketLife.WeatherAPI
{
    public class WeatherModel
    {
        public string City { get; set; }
        public string Country { get; set; }

        public double CurrentTemperature { get; set; }
        public string Description { get; set; }

        public int Humidity { get; set; }
        public int Pressure { get; set; }

        public double WindSpeed { get; set; }
        public int WindAngle { get; set; }

        public DateTime Sunset { get; set; }
        public DateTime Sunrise { get; set; }

    }
}
