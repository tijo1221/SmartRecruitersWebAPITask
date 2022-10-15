using GetCurrentWeatherWebAPI.Models;
using GetCurrentWeatherWebAPI.Services;

namespace GetCurrentWeatherWebAPITests
{
    public class WeatherOutputServiceTests
    {
        RootWeatherInputModel _model;
        private readonly string _countryName = "London";

        [SetUp]
        public void Setup()
        {
            _model = new RootWeatherInputModel();
            _model.WeatherSystem = new WeatherSystem();
            _model.Coordinate = new Coordinates();
            _model.Weather = new List<Weather>();
            _model.Wind = new Wind();
            _model.MainWeather = new MainWeather();
        }

        [Test]
        public void CreateCityWeatherOutput_CheckCountryName()
        {
            _model.WeatherSystem.Country = _countryName;

            var cityWeatherResult = WeatherOutputService.CreateCityWeatherOutput(_model);

            Assert.That(cityWeatherResult.CountryName, Is.EqualTo(_countryName));
        }
    }
}