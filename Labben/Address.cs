using Labben;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labben
{
    public class Address
    {
        private string? _street;
        private string? _suite;
        private string? _city;
        private string? _zipCode;
        

        [Required]
        [StringLength (50, MinimumLength = 2)]        
        public string Street { get { return _street; } set { _street = value; } }

        [Required]
        [StringLength (50,MinimumLength = 2)]
        public string City { get { return _city; } set { _city = value; } }

        [Required]
        //[Range(1000,99999)]
        public string ZipCode { get { return _zipCode; } set { _zipCode = value; } }

        [JsonIgnore]
        public string Suite { get { return _suite; } set { _suite = value; } }

        public Geo Geo { get; set; }
        
        public Address(string street, string city, string zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }
    }
}
