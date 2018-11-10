using System;
using Newtonsoft.Json;

namespace Movies.Service
{
    public partial class MovieResult
    {
        [JsonProperty("wrapperType")]
        public string WrapperType { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("trackId")]
        public long TrackId { get; set; }

        [JsonProperty("artistName")]
        public string ArtistName { get; set; }

        [JsonProperty("trackName")]
        public string TrackName { get; set; }

        [JsonProperty("trackCensoredName")]
        public string TrackCensoredName { get; set; }

        [JsonProperty("trackViewUrl")]
        public Uri TrackViewUrl { get; set; }

        [JsonProperty("previewUrl")]
        public Uri PreviewUrl { get; set; }

        [JsonProperty("artworkUrl30")]
        public Uri ArtworkUrl30 { get; set; }

        [JsonProperty("artworkUrl60")]
        public Uri ArtworkUrl60 { get; set; }

        [JsonProperty("artworkUrl100")]
        public Uri ArtworkUrl100 { get; set; }

        [JsonProperty("collectionPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? CollectionPrice { get; set; }

        [JsonProperty("trackPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? TrackPrice { get; set; }

        [JsonProperty("trackRentalPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? TrackRentalPrice { get; set; }

        [JsonProperty("collectionHdPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? CollectionHdPrice { get; set; }

        [JsonProperty("trackHdPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? TrackHdPrice { get; set; }

        [JsonProperty("trackHdRentalPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? TrackHdRentalPrice { get; set; }

        [JsonProperty("releaseDate")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonProperty("collectionExplicitness")]
        public string CollectionExplicitness { get; set; }

        [JsonProperty("trackExplicitness")]
        public string TrackExplicitness { get; set; }

        [JsonProperty("trackTimeMillis")]
        public long TrackTimeMillis { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("primaryGenreName")]
        public string PrimaryGenreName { get; set; }

        [JsonProperty("contentAdvisoryRating")]
        public string ContentAdvisoryRating { get; set; }

        [JsonProperty("longDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("hasITunesExtras", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasITunesExtras { get; set; }

        [JsonProperty("shortDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortDescription { get; set; }
    }
}
