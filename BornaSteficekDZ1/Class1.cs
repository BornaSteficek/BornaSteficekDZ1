using System;

namespace Zadaca1_Borna_Steficek
{
    public class Weather
    {
        private double temperature;
        private double humidity;
        private double windSpeed;

        public Weather()
        {
            temperature = humidity = windSpeed = 0;
        }
        public Weather(double a, double b, double c)
        {
            temperature = a;
            humidity = b;
            windSpeed = c;
        }
        public void SetTemperature(double a)
        {
            temperature = a;
        }

        public void SetWindSpeed(double a)
        {
            windSpeed = a;
        }

        public void SetHumidity(double a)
        {
            humidity = a;
        }

        public double GetTemperature()
        {
            return temperature;
        }

        public double GetHumidity()
        {
            return humidity;
        }

        public double GetWindSpeed()
        {
            return windSpeed;
        }

        public double CalculateFeelsLikeTemperature()
        {
            double heatIndex;
            heatIndex = (-8.78469475556 + 1.61139411 * temperature + 2.33854883889 * humidity + (-0.14611605) * temperature * humidity + (-0.012308094) * Math.Pow(temperature, 2) + (-0.0164248277778) * Math.Pow(humidity, 2) + 0.002211732 * Math.Pow(temperature, 2) * humidity + 0.00072546 * temperature * Math.Pow(humidity, 2) + (-0.000003582) * Math.Pow(temperature, 2) * Math.Pow(humidity, 2));
            return heatIndex;
        }

        public double CalculateWindChill()
        {
            double windChill;
            if (temperature > 10 || windSpeed <= 4.8)
                return 0;
            windChill = (13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow(windSpeed, 0.16)); ;
            return windChill;
        }


    }
}