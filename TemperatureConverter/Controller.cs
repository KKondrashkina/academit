using System;
using System.Collections.Generic;
using System.Linq;
using TemperatureConverter.TemperatureUnit;

namespace TemperatureConverter
{
    class Controller
    {
        List<ITemperatureUnit> temperatureUnits = new List<ITemperatureUnit>();

        public string[] UOMsList => temperatureUnits.Select(n => n.Name).ToArray();

        public Controller()
        {
            Kelvin kelvin = new Kelvin();
            Fahrenheit fahrenheit = new Fahrenheit();
            Celsius celsius = new Celsius();

            temperatureUnits.Add(kelvin);
            temperatureUnits.Add(fahrenheit);
            temperatureUnits.Add(celsius);
        }

        public string ChangeValue(string text, string unitOfMeasurement1, string unitOfMeasurement2)
        {
            if (IsNumber(text))
            {
                return GetValue(text, unitOfMeasurement1, unitOfMeasurement2);
            }

            if (text != "")
            {
                return "Введите число.";
            }

            return "";
        }

        private string GetValue(string text, string unitOfMeasurement1, string unitOfMeasurement2)
        {
            if (unitOfMeasurement1 == "" || unitOfMeasurement2 == "")
            {
                return "";
            }

            ITemperatureUnit from = temperatureUnits.First(n => n.Name == unitOfMeasurement1);
            ITemperatureUnit to = temperatureUnits.First(n => n.Name == unitOfMeasurement2);

            return Convert.ToString(to.ConvertFromCelsius(from.ConvertToCelsius(Convert.ToDouble(text))));
        }

        private static bool IsNumber(string value)
        {
            return double.TryParse(value, out double result);
        }
    }
}
