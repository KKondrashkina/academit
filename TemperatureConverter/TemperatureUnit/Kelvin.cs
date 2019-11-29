namespace TemperatureConverter.TemperatureUnit
{
    class Kelvin : ITemperatureUnit
    {
        public string Name
        {
            get
            {
                return "Kelvins";
            }
        }

        public double ConvertToCelsius(double value)
        {
            return value - 273.15;
        }

        public double ConvertFromCelsius(double value)
        {
            return value + 273.15;
        }
    }
}
