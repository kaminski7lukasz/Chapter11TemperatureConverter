using TemperatureConverterWebApi;
namespace TemperatureConverterUnitTests
{
    public class ConverterTests
    {
        [Theory]
        [TestCase(1, -17)]
        [TestCase(50, 10)]
        [TestCase(95, 35)]
        [TestCase(73, 22)]
        public void Should_ReturnProperlyConverted_When_Converting_FromFahrenheit_ToCelsius(double from, double result)
        {
            Assert.AreEqual(result, Converter.ToCelsius(ETemperatureUnit.Farenheit, from));
        }

        [Theory]
        [TestCase(273, 0)]
        [TestCase(300, 27)]
        [TestCase(268, -5)]
        public void Should_ReturnProperlyConverted_When_Converting_FromKelvin_ToCelsius(double from, double result)
        {
            Assert.That(result, Is.EqualTo(Converter.ToCelsius(ETemperatureUnit.Kelvin, from)));
        }

        [Theory]
        [TestCase(15, 59)]
        [TestCase(-27, -16)]
        [TestCase(42, 107)]
        public void Should_ReturnProperlyConverted_When_Converting_FromCelsius_ToFahrenheit(double from, double result)
        {
            Assert.That(result, Is.EqualTo(Converter.ToFahrenheit(ETemperatureUnit.Celsius, from)));
        }

        [Theory]
        [TestCase(288, 59)]
        [TestCase(246, -16)]
        [TestCase(315, 107)]
        public void Should_ReturnProperlyConverted_When_Converting_FromKelvin_ToFahrenheit(double from, double result)
        {
            Assert.That(result, Is.EqualTo(Converter.ToFahrenheit(ETemperatureUnit.Kelvin, from)));
        }

        [Theory]
        [TestCase(15, 288)]
        [TestCase(27, 300)]
        [TestCase(100, 373)]
        public void Should_ReturnProperlyConverted_When_Converting_FromCelsius_ToKelvin(double from, double result)
        {
            Assert.That(result, Is.EqualTo(Converter.ToKelvin(ETemperatureUnit.Celsius, from)));
        }

        [Theory]
        [TestCase(1, 255)]
        [TestCase(50, 283)]
        [TestCase(95, 308)]
        [TestCase(73, 295)]
        public void Should_ReturnProperlyConverted_When_Converting_FromFahrenheit_ToKelvin(double from, double result)
        {
            Assert.That(result, Is.EqualTo(Converter.ToKelvin(ETemperatureUnit.Farenheit, from)));
        }
    }
}