using Newtonsoft.Json;

namespace GetCurrentWeatherWebAPI.Models
{
    public class RootWeatherInputModel
    {
        [JsonProperty("coord")]
        public Coordinates? Coordinate { get; set; }

        [JsonProperty("weather")]
        public List<Weather>? Weather { get; set; }

        [JsonProperty("base")]
        public string? Base { get; set; }

        [JsonProperty("main")]
        public MainWeather? MainWeather { get; set; }

        [JsonProperty("visibility")]
        public int? Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind? Wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds? Clouds { get; set; }

        [JsonProperty("dt")]
        public int? Dt { get; set; }

        [JsonProperty("sys")]
        public WeatherSystem? WeatherSystem { get; set; }

        [JsonProperty("timezone")]
        public int? Timezone { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string? CityName { get; set; }

        [JsonProperty("cod")]
        public int? Coordinates { get; set; }
    }
}
