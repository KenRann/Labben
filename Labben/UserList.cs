using System.Security.Policy;
using System.Xml.Linq;

namespace Labben
{
    public class UserList : IGetUsers
    {
        private List<Person> _listOfPeople = new List<Person>
        {
                    new Person(8901, "Emma", "Lindström", "emma.lindstrom@Gmail.com",new Company("Blomsterdesign AB", "Skapa ditt drömrum med naturens skönhet."), new Residence("Månskenstorget 3", "Stockholm", 18429)),
                    new Person(4567, "Felix", "Andersson", "felix.andersson@Yahoo.com", new Company("TechSolutions Group", "Framtiden börjar här, med smarta lösningar."), new Residence("Karamellvägen 9","Umeå",17302)),
                    new Person(0123, "Nora", "Karlsson","nora.karlsson@Exec.com", new Company("Grön Energi Sverige", "Tillsammans för en hållbar framtid."),new Residence("Granitgatan 19","Uppsala",17942)),
                    new Person(6789, "Leo", "Eriksson","leo.eriksson@Hotmail.com", new Company("Kreativa Byrån", "Din vision, vår kreativitet."),new Residence("Vitsippsstigen 4","Malmö",19420)),
                    new Person(2345, "Sofia", "Björk","sofia.bjork@Outlook.com",new Company("Mat & Mer Restaurang", "Smaker som förenar."),new Residence("Sjögrens Gata 22","Göteborg",18582)),
                    new Person(7890, "Max", "Johansson","max.johansson@Gmail.com",new Company("Svenska Byggteamet", "Bygger framtiden, sten för sten."),new Residence("Stjärnklara Torg 5","Kiruna",17890)),
                    new Person(3456, "Alva", "Nilsson","alva.nilsson@Outlook.com",new Company("Digitala Visioner", "Vi förverkligar dina digitala drömmar."),new Residence("Ekbacksvägen 34,","Stockholm",17382)),
                    new Person(9012, "Oliver", "Svensson","oliver.svensson@Yahoo.com",new Company("Hälsosamma Val", "Din väg till en bättre livsstil."),new Residence("Ljusets Allé 88","Malmö",19846)),
                    new Person(5678, "Klara", "Pettersson","klara.pettersson@Exec.com",new Company("Kultur & Nöje", "Upplev mer, lev mer."),new Residence("Rödklövergatan 7","Norrköping",18677)),
                    new Person(1234, "Axel", "Gustafsson","axel.gustafsson@example.com",new Company("Nordisk Logistik", "Effektivitet som når fram." ),new Residence("Solrosvägen 12","Göteborg", 18953))
        };
        public UserList()
        {
        }
        public void AddUser(int id, string fName, string lName,  string email, string companyName, string companyCPhrase, string street, string city, int zipCode)
        {
            _listOfPeople.Add(new Person(id, fName, lName, email, new Company(companyName, companyCPhrase),  new Residence(street, city, zipCode)));
        }

        public List<int> GetId()
        {
            return _listOfPeople.Select(p => p.Id).ToList();
        }

        public IQueryable<Person> GetUsers()
        {            
            IQueryable<Person> listOfPeople = _listOfPeople.AsQueryable();
            return listOfPeople;
        }

        //public Person GetLastUser()
        //{ 
        //    Person lastUser = _listOfPeople.Last();
        //    return lastUser;
        //}
    }
}
