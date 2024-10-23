namespace Labben
{
    public class Residence
    {
        private string _street;
        private string _city;
        private int _zipCode;

        public string Street { get { return _street; } set { _street = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public int ZipCode { get { return _zipCode; } set { _zipCode = value; } }
        public Residence(string street, string city, int zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }
    }
}
//    "Månskenstorget 3",
//    "Karamellvägen 9",
//    "Granitgatan 19",
//    "Vitsippsstigen 4",
//    "Sjögrens Gata 22",
//    "Stjärnklara Torg 5",
//    "Ekbacksvägen 34,",
//    "Ljusets Allé 88",
//    "Rödklövergatan 7",
//    "Solrosvägen 12"

//    "Stockholm",
//    "Umeå",
//    "Uppsala",
//    "Malmö",
//    "Göteborg",
//    "Kiruna",
//    "Stockholm",
//    "Malmö",
//    "Norrköping",
//    "Göteborg"

//    18429,
//    17302,
//    17942,
//    19420,
//    18582,
//    17890,
//    17382, 
//    19846, 
//    18677,
//    18953  