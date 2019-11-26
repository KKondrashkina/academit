namespace TemperatureConverter.TemperatureUnit
{
    interface ITemperatureUnit
    {
        double ConvertToCelsius(double value);

        double ConvertFromCelsius(double value);
    }
}
