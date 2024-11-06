using System.ComponentModel.DataAnnotations;


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
        public string FirstName { get { return _fName; } set { _fName = value; } }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get { return _lName; } set { _lName = value; } }
        [Required]
        [EmailAddress]
        public string EMail { get { return _email; } set { _email = value; } }

        [ValidateComplexType]
        public Company Company { get; set; }

        [ValidateComplexType]
        public Address Residence { get; set; }

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
            _fName = fName;
            _lName = lName;
            _email = email;
            Company = company;
            Residence = residence;
        }
    }
}
