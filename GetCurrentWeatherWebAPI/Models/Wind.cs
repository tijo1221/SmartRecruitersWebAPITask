using Newtonsoft.Json;

namespace GetCurrentWeatherWebAPI.Models
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double? Speed { get; set; }

        [JsonProperty("deg")]
        public int? Direction { get; set; }

        [JsonProperty("gust")]
        public double? Gust { get; set; }
    }
}
