using System.ComponentModel.DataAnnotations;

namespace Labben
{
    public class Address
    {
        private string _street;
        private string _city;
        private int _zipCode;

        [Required]
        [StringLength (50, MinimumLength = 2)]        
        public string Street { get { return _street; } set { _street = value; } }

        [Required]
        [StringLength (50,MinimumLength = 2)]
        public string City { get { return _city; } set { _city = value; } }

        [Required]
        [Range(1000,99999)]
        public int ZipCode { get { return _zipCode; } set { _zipCode = value; } }

        public Address(string street, string city, int zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }
    }
}
