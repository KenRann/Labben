using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json.Serialization;


namespace Labben
{
    public class Person
    {
        int _id;
        string? _name;
        string? _lName;
        string? _email;

        string _userName;
        string _phone;
        string _website;

        public int Id { get { return _id; } set { _id = value; } }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get { return _name; } set { _name = value; } }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get { return _lName; } set { _lName = value; } }
        [Required]
        [EmailAddress]
        public string EMail { get { return _email; } set { _email = value; } }

        [JsonIgnore]
        public string UserName { get { return _userName;} set { _userName = value; } }
        [JsonIgnore]
        public string Phone { get { return _phone; } set { _phone = value; } }
        [JsonIgnore]
        public string Website { get { return _website; } set { _website = value; } }

        [ValidateComplexType]
        public Company Company { get; set; }

        [ValidateComplexType]
        public Address Address { get; set; }

        public Person()
        {           
        }
        //public Person(int id, string name, string username, string eMail, Address address, string phone, string website, Company company)
        //{
        //    Id = id;
        //    Name = name;
        //    UserName = username;
        //    EMail = eMail;
        //    Address = address;
        //    Phone = phone;
        //    Website = website;
        //    Company = company;
        //    Address = address;
        //}
        public Person(int id, string name, string email, Company company, Address residence) 
        {
            Id = id;
            Name = name;            
            EMail = email;
            Company = company;
            Address = residence;
        }
    }
}
