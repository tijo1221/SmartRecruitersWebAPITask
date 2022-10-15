﻿using Newtonsoft.Json;

namespace GetCurrentWeatherWebAPI.Models
{
    public class WeatherSystem
    {
        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("sunrise")]
        public int? Sunrise { get; set; }

        [JsonProperty("sunset")]
        public int? Sunset { get; set; }
    }
}
