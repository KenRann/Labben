namespace Labben
{
    public class GenPersonPInfo
    {
        int _id;
        string _name;
        string _email;
        //List<int> _id = new List<int>
        //{
        //    2005-05-05-8901,
        //    1970-01-01-4567,
        //    1995-09-18-0123,
        //    1988-03-25-6789,
        //    1990-12-12-2345,
        //    1983-06-07-7890,
        //    2001-08-19-3456,
        //    1975-02-22-9012,
        //    1992-11-30-5678,
        //    1987-04-15-1234
        //};
        //List<string> _name = new List<string> 
        //{ 
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
        //};
        //List<string> _email = new List<string> 
        //{
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
        //};

        //public List<int> Id { get { return _id; } set { _id = value; } }
        //public List<string> Name { get { return _name; } set { _name = value; } }
        //public List<string> EMail { get { return _email; } set { _email = value; } }

        public int Id {  get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string EMail { get { return _email; } set { _email = value; } }
        public GenPersonPInfo(int id, string name, string email)
        {
            Id = id;
            _name = name;
            _email = email;
        }

    }
}
