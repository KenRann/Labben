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

        //[Required]
        //[StringLength(75, MinimumLength = 2)]
        public string CatchPhrase { get { return _catchPhrase; } set { _catchPhrase = value; } }

        //[JsonIgnore]
        public string Bs { get { return _bs; } set { _bs = value; } }

        [JsonConstructor]
        public Company(string compName, string compCPhrase, string bs)
        {
            Name = compName;
            CatchPhrase = compCPhrase;
            Bs = bs;
        }
        
        public Company(string compName, string compCPhrase)
        {
            CompanyName = compName;
            CompanyCPhrase = compCPhrase;
        }
    }
}
