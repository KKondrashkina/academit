﻿using System;
using System.Windows.Forms;
using TemperatureConverter.TemperatureUnit;

namespace TemperatureConverter
{
    class Controller
    {
        public static string ChangeValue(string text, string unitOfMeasurement1, string unitOfMeasurement2)
        {
            if (IsNumber(text))
            {
                return GetValue(text, unitOfMeasurement1, unitOfMeasurement2);
            }

            if (text != "")
            {
                MessageBox.Show("Ошибка! Введено не число.");
            }

            return "";
        }

        private static string GetValue(string text, string unitOfMeasurement1, string unitOfMeasurement2)
        {
            Kelvin kelvin = new Kelvin();
            Fahrenheit fahrenheit = new Fahrenheit();

            if (unitOfMeasurement1 == "Celsius degrees")
            {
                if (unitOfMeasurement2 == "Celsius degrees")
                {
                    return text;
                }
                else if (unitOfMeasurement2 == "Kelvins")
                {
                    return Convert.ToString(kelvin.ConvertFromCelsius(Convert.ToDouble(text)));
                }
                else if (unitOfMeasurement2 == "Fahrenheit degrees")
                {
                    return Convert.ToString(fahrenheit.ConvertFromCelsius(Convert.ToDouble(text)));
                }
            }
            else if (unitOfMeasurement1 == "Kelvins")
            {
                if (unitOfMeasurement2 == "Kelvins")
                {
                    return text;
                }
                else if (unitOfMeasurement2 == "Celsius degrees")
                {
                    return Convert.ToString(kelvin.ConvertToCelsius(Convert.ToDouble(text)));
                }
                else if (unitOfMeasurement2 == "Fahrenheit degrees")
                {
                    return Convert.ToString(fahrenheit.ConvertFromCelsius(kelvin.ConvertToCelsius(Convert.ToDouble(text))));
                }
            }
            else if (unitOfMeasurement1 == "Fahrenheit degrees")
            {
                if (unitOfMeasurement2 == "Fahrenheit degrees")
                {
                    return text;
                }
                else if (unitOfMeasurement2 == "Celsius degrees")
                {
                    return Convert.ToString(fahrenheit.ConvertToCelsius(Convert.ToDouble(text)));
                }
                else if (unitOfMeasurement2 == "Kelvins")
                {
                    return Convert.ToString(kelvin.ConvertFromCelsius(fahrenheit.ConvertToCelsius(Convert.ToDouble(text))));
                }
            }

            return "";
        }

        private static bool IsNumber(string value)
        {
            return double.TryParse(value, out double result);
        }
    }
}
