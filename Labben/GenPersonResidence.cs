namespace Labben
{
    public class GenPersonResidence
    {
        List<string> street = new List<string> 
        { 
            "Månskenstorget 3",
            "Karamellvägen 9",
            "Granitgatan 19",
            "Vitsippsstigen 4",
            "Sjögrens Gata 22",
            "Stjärnklara Torg 5",
            "Ekbacksvägen 34,",
            "Ljusets Allé 88",
            "Rödklövergatan 7",
            "Solrosvägen 12"
        };
        List<string> city = new List<string> 
        { 
            "Stockholm",
            "Umeå",
            "Uppsala",
            "Malmö",
            "Göteborg",
            "Kiruna",
            "Stockholm",
            "Malmö",
            "Norrköping",
            "Göteborg"
        };
        List<int> zipCode = new List<int> 
        { 
            18429,
            17302,
            17942,
            19420,
            18582,
            17890,
            17382, 
            19846, 
            18677,
            18953  
        };

        private string _street;
        private string _city;
        private int _zipCode;

        public string Street { get { return _street; } set { _street = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public int ZipCode { get { return _zipCode; } set { _zipCode = value; } }
        public GenPersonResidence(string street, string city, int zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }
    }
}
