using System.Text.Json.Serialization;

namespace HttpClientDemo.Models
{
    public class DayForcastModel
    {
        [JsonPropertyName("weather_state_name")]
        public string WeatherStateName { get; set; }

        [JsonPropertyName("applicable_date")]
        public string ApplicableDate { get; set; }

        [JsonPropertyName("min_temp")]
        public float MinTemp { get; set; }

        [JsonPropertyName("max_temp")]
        public float MaxTemp { get; set; }
    }
}
