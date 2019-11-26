namespace TemperatureConverter.TemperatureUnit
{
    class Kelvin : ITemperatureUnit
    {
        public double ConvertToCelsius(double value)
        {
            return value - 273.15;
        }

        public double ConvertFromCelsius(double value)
        {
            return value +273.15;
        }
    }
}
