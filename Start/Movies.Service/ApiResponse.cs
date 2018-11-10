using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Movies.Service
{
    public partial class ApiResponse
    {
        [JsonProperty("resultCount")]
        public long ResultCount { get; set; }

        [JsonProperty("results")]
        public MovieResult[] Results { get; set; }

        public static ApiResponse FromJson(string json) => JsonConvert.DeserializeObject<ApiResponse>(json, Converter.Settings);

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
                }
            };
        }
    }
}
