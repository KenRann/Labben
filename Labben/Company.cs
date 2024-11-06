using System.ComponentModel.DataAnnotations;

namespace Labben
{
    public class Company
    {
        private string? _companyName;
        private string? _catchPhrase;
        private string? _bs;

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? Name { get { return _companyName; } set { _companyName = value; } }

        [Required]
        [StringLength(75, MinimumLength = 2)]
        public string CatchPhrase { get { return _catchPhrase; } set { _catchPhrase = value; } }

        public string Bs { get { return _bs; } set { _bs = value; } }

        //[JsonConstructor]
        //public Company(string name, string catchPhrase, string bs)
        //{
        //    Name = name;
        //    CatchPhrase = catchPhrase;
        //    Bs = bs;
        //}

        public Company(string name, string catchPhrase)
        {
            Name = name;
            CatchPhrase = catchPhrase;
        }
    }
}
