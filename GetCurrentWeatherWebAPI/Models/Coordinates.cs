using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace GetCurrentWeatherWebAPI.Models
{   
    public class Coordinates
    {
        [JsonProperty("lon")]
        public double? Longitude { get; set; }

        [JsonProperty("lat")]
        public double? Latitude { get; set; }
    }
}
