namespace Labben
{
    public class Person
    {
        int _id;
        string _name;
        string _email;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string EMail { get { return _email; } set { _email = value; } }

        public Company Company { get; set; }
        public Residence Residence { get; set; }

        public Person(int id, string name, string email, Company company, Residence residence)
        {
            Id = id;
            _name = name;
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