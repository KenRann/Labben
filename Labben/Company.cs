using System.ComponentModel.DataAnnotations;

namespace Labben
{
    public class Company
    {
        private string _companyName;
        private string _companyCPhrase;

        [Required]
        [StringLength(50, MinimumLength =2)]
        public string? CompanyName { get { return _companyName; } set { _companyName = value; } }

        [Required]
        [StringLength (75,MinimumLength = 2)]
        public string? CompanyCPhrase { get { return _companyCPhrase; } set { _companyCPhrase = value; } }

        public Company(string compName, string compCPhrase)
        {
            CompanyName = compName;
            CompanyCPhrase = compCPhrase;
        }
    }
}
