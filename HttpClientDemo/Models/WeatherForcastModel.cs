using System;
using System.Text.Json.Serialization;

namespace HttpClientDemo.Models
{

    public class WeatherForcastModel
    {
        public DayForcastModel[] Consolidated_weather { get; set; }

        [JsonPropertyName("sun_rise")]
        public DateTime SunRise { get; set; }

        [JsonPropertyName("sun_set")]
        public DateTime SunSet { get; set; }

        public string Title { get; set; }
        public string Timezone { get; set; }
    }
}
