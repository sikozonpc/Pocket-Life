using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocketLife.WeatherAPI
{
    public class WeatherJsonModel
    {
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class weather
        {
            public int id { get; set; }
            // Weather condition
            public string main { get; set; }
            // Brief description about the current weather
            public string description { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }

        public class wind
        {
            public double speed { get; set; }
            public int deg { get; set; }
        }

        public class sys
        {
            // Country name 
            public string country { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
        }

        public class Root
        {
            // City name
            public string name { get; set; }
            public sys sys { get; set; }
            public double dt { get; set; }
            public wind wind { get; set; }
            public main main { get; set; }
            public List<weather> weather { get; set; }
            public coord coordinate { get; set; }
        }


    }
}
