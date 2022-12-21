
using Newtonsoft.Json;

namespace OOP.VCard.Models
{
    public class VCard
    {
        [JsonProperty("id")]
        public Id Id { get; set; }
        [JsonProperty("name")]
        public Info Info { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("location")]
        public Location Location { get; set; }
    }

    public class Location
    {
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }

    }
    public class Info
    {
        [JsonProperty("first")]
        public string Name { get; set; }
        [JsonProperty("last")]
        public string Surname { get; set; }

    }
    public class Id
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
