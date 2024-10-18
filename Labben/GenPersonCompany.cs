namespace Labben
{
    public class GenPersonCompany
    {
        //List <string> CompanyName = new List<string> 
        //{ 
        //    "Blomsterdesign AB",
        //    "TechSolutions Group",
        //    "Grön Energi Sverige",
        //    "Kreativa Byrån",
        //    "Mat & Mer Restaurang", 
        //    "Svenska Byggteamet",
        //    "Digitala Visioner", 
        //    "Hälsosamma Val", 
        //    "Kultur & Nöje", 
        //    "Nordisk Logistik" 
        //};
        //List <string> CompanyCPhrase = new List<string> 
        //{
        //    "Skapa ditt drömrum med naturens skönhet.",
        //    "Framtiden börjar här, med smarta lösningar.",
        //    "Tillsammans för en hållbar framtid.",
        //    "Din vision, vår kreativitet.",
        //    "Smaker som förenar.",
        //    "Bygger framtiden, sten för sten.",
        //    "Vi förverkligar dina digitala drömmar.",
        //    "Din väg till en bättre livsstil.",
        //    "Upplev mer, lev mer.",
        //    "Effektivitet som når fram."
        //};

        private string _companyName;
        private string _companyCPhrase;

        public string CompanyName { get { return _companyName; } set { _companyName = value; } }
        public string CompanyCPhrase { get { return _companyCPhrase; } set { _companyCPhrase = value; } }

        public GenPersonCompany(string compName, string compCPhrase)
        {
            CompanyName = compName;
            CompanyCPhrase = compCPhrase;
        }

    }
}
