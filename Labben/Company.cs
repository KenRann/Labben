using System.ComponentModel.DataAnnotations;

namespace Labben
{
    public class Company
    {
        private string? _companyName;
        private string? _companyCPhrase;

        [Required]
        [StringLength(50, MinimumLength =2)]
        public string CompanyName { get { return _companyName; } set { _companyName = value; } }

        [Required]
        [StringLength (75,MinimumLength = 2)]
        public string CompanyCPhrase { get { return _companyCPhrase; } set { _companyCPhrase = value; } }

        public Company(string compName, string compCPhrase)
        {
            CompanyName = compName;
            CompanyCPhrase = compCPhrase;
        }
    }
}
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