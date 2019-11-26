namespace TemperatureConverter.TemperatureUnit
{
    class Fahrenheit : ITemperatureUnit
    {
        public double ConvertToCelsius(double value)
        {
            return (value - 32) * 9 / 5;
        }

        public double ConvertFromCelsius(double value)
        {
            return value * 9 / 5 + 32;
        }
    }
}
