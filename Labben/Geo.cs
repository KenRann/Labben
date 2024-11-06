using System.Text.Json.Serialization;

namespace Labben
{
    public class Geo
    {
        private string? _lat { get; set; }
        private string? _lng { get; set; }

        [JsonIgnore]
        public string Lat { get { return _lat; } set { _lat = value; } }
        [JsonIgnore]
        public string Lng { get { return _lng; } set { _lng = value; } }

        [JsonConstructor]
        public Geo(string lat, string lng)
        {
            Lat = lat;
            Lng = lng;
        }
        public Geo()
        { }
    }
}
