using System.ComponentModel.DataAnnotations;


namespace Labben
{
    public class Person
    {
        int _id;
        string? _name;
        string? _lName;
        string? _email;
        string? _userName;
        string? _phone;
        string? _website;

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

        public string UserName { get { return _userName; } set { _userName = value; } }

        [Required]
        [ValidateComplexType]
        public Company Company { get; set; }

        [Required]
        [ValidateComplexType]
        public Address Address { get; set; }

        public Person()
        {
        }
        public Person(int id, string name,  string email, Company company, Address address)
        {
            Id = id;
            Name = name;
            _email = email;
            Company = company;
            Address = address;
        }
    }
}
