using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labben
{
    public class Company
    {
        private string? _companyName;
        private string? _catchPhrase;

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get { return _companyName; } set { _companyName = value; } }

        [Required]
        [StringLength(75, MinimumLength = 2)]
        public string CatchPhrase { get { return _catchPhrase; } set { _catchPhrase = value; } }

        public Company(string name, string catchPhrase)
        {
            Name = name;
            CatchPhrase = catchPhrase;
        }
    }
}
