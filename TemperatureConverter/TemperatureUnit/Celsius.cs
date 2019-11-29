namespace TemperatureConverter.TemperatureUnit
{
    class Celsius : ITemperatureUnit
    {
        public string Name
        {
            get
            {
                return "Celsius degrees";
            }
        }

        public double ConvertFromCelsius(double value)
        {
            return value;
        }

        public double ConvertToCelsius(double value)
        {
            return value;
        }
    }
}
