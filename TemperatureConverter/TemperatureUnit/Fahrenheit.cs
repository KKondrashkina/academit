namespace TemperatureConverter.TemperatureUnit
{
    class Fahrenheit : ITemperatureUnit
    {
        public string Name => "Fahrenheit degrees";

        public double ConvertToCelsius(double value)
        {
            return (value - 32) * 5 / 9;
        }

        public double ConvertFromCelsius(double value)
        {
            return value * 9 / 5 + 32;
        }
    }
}
