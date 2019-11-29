namespace TemperatureConverter.TemperatureUnit
{
    interface ITemperatureUnit
    {
        string Name { get; }

        double ConvertToCelsius(double value);

        double ConvertFromCelsius(double value);
    }
}
