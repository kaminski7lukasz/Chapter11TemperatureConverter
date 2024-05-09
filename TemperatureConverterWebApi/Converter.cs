namespace TemperatureConverterWebApi;
public static class Converter
{
    public static int ToCelsius(ETemperatureUnit @from, double temperature) =>
        @from switch
        {
            ETemperatureUnit.Farenheit => (int)(5 * (temperature - 32) / 9),
            ETemperatureUnit.Kelvin => (int)temperature - 273,
            _ => (int)temperature,

        };
    public static int ToFahrenheit(ETemperatureUnit @from, double temperature) =>
    @from switch
    {
        ETemperatureUnit.Celsius => (int)((1.8 * temperature) + 32),
        ETemperatureUnit.Kelvin => (int) ((temperature - 273) * 1.8 +32),
        _ => (int) temperature,

    };
    public static int ToKelvin(ETemperatureUnit @from, double temperature) =>
    @from switch
    {
        ETemperatureUnit.Celsius => (int)(temperature + 273),
        ETemperatureUnit.Farenheit => (int)(((temperature - 32) * 5 / 9) + 273),
        _ => (int)temperature,

    };

}
