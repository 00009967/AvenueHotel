using _00009967.Helper.Enums;
using System.ComponentModel.DataAnnotations;

namespace _00009967.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Phonenumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public string Password { get; set; }
        public string Salt { get; set; }
        public UserType Type { get; set; }
        public UserStatus Status { get; set; }



    }
}
