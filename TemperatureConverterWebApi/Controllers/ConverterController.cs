using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TemperatureConverterWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConverterController : ControllerBase
    {
        private readonly ILogger<ConverterController> _logger;

        public ConverterController(ILogger<ConverterController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int TemperatureConverter(
            [Required][FromQuery] ETemperatureUnit from,
            [Required][FromQuery] ETemperatureUnit to,
            [Required][FromQuery] double value)
        {
            return (from, to) switch
            {
                (ETemperatureUnit.Celsius, ETemperatureUnit.Farenheit) => Converter.ToFahrenheit(ETemperatureUnit.Celsius, value),
                (ETemperatureUnit.Kelvin, ETemperatureUnit.Farenheit) => Converter.ToFahrenheit(ETemperatureUnit.Kelvin, value),
                (ETemperatureUnit.Farenheit, ETemperatureUnit.Celsius) => Converter.ToCelsius(ETemperatureUnit.Celsius, value),
                (ETemperatureUnit.Kelvin, ETemperatureUnit.Celsius) => Converter.ToCelsius(ETemperatureUnit.Celsius, value),
                (ETemperatureUnit.Farenheit, ETemperatureUnit.Kelvin) => Converter.ToKelvin(ETemperatureUnit.Celsius, value),
                (ETemperatureUnit.Celsius, ETemperatureUnit.Kelvin) => Converter.ToKelvin(ETemperatureUnit.Celsius, value),
                _ => (int)value
            };

        }
    }
}
