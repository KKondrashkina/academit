namespace TemperatureConverter
{
    class Model
    {
        public static double ConvertCelsiusToKelvin(double celsiusDegrees)
        {
            return celsiusDegrees + 273.15;
        }

        public static double ConvertCelsiusToFahrenheit(double celsiusDegrees)
        {
            return celsiusDegrees * 9 / 5 + 32;
        }

        public static double ConvertKelvinToCelsius(double kelvins)
        {
            return kelvins - 273.15;
        }

        public static double ConvertKelvinToFahrenheit(double kelvins)
        {
            return (kelvins - 273.15) * 9 / 5 + 32;
        }

        public static double ConvertFahrenheitToCelsius(double fahrenheitDegrees)
        {
            return (fahrenheitDegrees - 32) * 9 / 5;
        }

        public static double ConvertFahrenheitToKelvin(double fahrenheitDegrees)
        {
            return (fahrenheitDegrees - 32) * 5 / 9 + 273.15;
        }
    }
}
