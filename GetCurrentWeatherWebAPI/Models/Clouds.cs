using Newtonsoft.Json;

namespace GetCurrentWeatherWebAPI.Models
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int? All { get; set; }
    }
}
