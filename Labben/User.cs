using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;

namespace Labben
{
    public class User
    {
        private string? _firstName;
        private string? _lastName;
        private string? _eMail;
        private DateOnly _dateOfBirth;
        private string? _gender;

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        [Required]
        [EmailAddress]
        public string EMail { get { return _eMail; } set { _eMail = value; } }

        [Required]
        
        public DateOnly DateOfBirth { get { return (DateOnly)_dateOfBirth;  } set{ _dateOfBirth = value; } }

        [Required(ErrorMessage = "Select a gender option.")]
        public string Gender { get { return _gender; } set { _gender = value; } }

        public User(string fName, string lName, string eMail, DateOnly dateOfBirth, string gender)
        {
            FirstName = fName;
            LastName = lName;
            EMail = eMail;
            DateOfBirth = (DateOnly)dateOfBirth;
            Gender = gender;
        }
        public User() { }
    }
}
