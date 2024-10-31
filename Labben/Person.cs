using System.ComponentModel.DataAnnotations;


namespace Labben
{
    public class Person
    {
        int _id;
        string _fName;
        string _lName;
        string _email;

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

        //[Required]
        [ValidateComplexType]
        public Company Company { get; set; }
        //[Required]
        [ValidateComplexType]
        public Residence Residence { get; set; }

        public Person()
        {           
        }

        public Person(int id, string fName, string lName, string email, Company company, Residence residence)
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
//    8901,
//    4567,
//    0123,
//    6789,
//    2345,
//    7890,
//    3456,
//    9012,
//    5678,
//    1234

//    "Emma Lindström",
//    "Felix Andersson",
//    "Nora Karlsson",
//    "Leo Eriksson",
//    "Sofia Björk",
//    "Max Johansson",
//    "Alva Nilsson",
//    "Oliver Svensson",
//    "Klara Pettersson",
//    "Axel Gustafsson"

//    "emma.lindstrom@Gmail.com",
//    "felix.andersson@Yahoo.com",
//    "nora.karlsson@Exec.com",
//    "leo.eriksson@Hotmail.com",
//    "sofia.bjork@Outlook.com",
//    "max.johansson@Gmail.com",
//    "alva.nilsson@Outlook.com",
//    "oliver.svensson@Yahoo.com",
//    "klara.pettersson@Exec.com",
//    "axel.gustafsson@example.com"