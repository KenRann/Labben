using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labben
{
    public class Company
    {
        private string? _name;
        private string? _catchPhrase;
        private string? _bs;

        [Required]
        [StringLength(50, MinimumLength =2)]
        public string Name { get { return _name; } set { _name = value; } }

        [Required]
        [StringLength(75, MinimumLength =2)]
        public string CatchPhrase { get { return _catchPhrase; } set { _catchPhrase = value; } }

        [JsonIgnore]
        public string Bs { get { return _bs; } set { _bs = value; } }

        public Company(string compName, string compCPhrase, string bs)
        {
            Name = compName;
            CatchPhrase = compCPhrase;
            Bs = bs;
        }
        public Company(string compName, string compCPhrase)
        {
            Name = compName;
            CatchPhrase = compCPhrase;           
        }
    }
}
