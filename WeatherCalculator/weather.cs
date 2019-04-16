using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherCalculator
{
    class Weather //class for to hold weather data
    {
        public int highTemp;
        public int lowTemp;
        public int windSpeed;
        private string _skyCondition;
        private double _windChill;
        public string skyUrl;

        public double windChill
        {
            get
            {    
                //https://stackoverflow.com/questions/35120439/wind-chill-c-sharp-final-number-needs-more-digits                       
                _windChill = 35.74 + 0.6215 * lowTemp + (0.4275 * lowTemp - 35.75) * Math.Pow(windSpeed, 0.16);
                _windChill = Math.Round(_windChill, 2);
                return _windChill;
            } 
            set
            {
                _windChill = value;
            }
        }

        public string skyCondition
        {
            get
            {
                
                return _skyCondition;
            }
            set
            {
                _skyCondition = value.ToLower();
                if (_skyCondition == "sunny")
                {
                    skyUrl = "https://requestreduce.org/images/large-clipart-sun-8.png";
                }
                else if (_skyCondition == "rainy")
                {
                    skyUrl = "https://cdn0.wideopencountry.com/wp-content/uploads/2018/07/country-songs-about-rain-793x526.jpg";
                }
                else
                {
                    skyUrl = "https://asmallorange.com/assets/img/services/cloud.png";
                }
            }
        }

        public Weather()
        {
            highTemp = 0;//intializes properties
            lowTemp = 0;
            _windChill = 0;
            _skyCondition = "";
        }
    }
}
