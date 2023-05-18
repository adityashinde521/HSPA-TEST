using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public byte[] Password { get; set; }

        public byte[] PasswordKey { get; set; }
    }
}

/*using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    public class User : BaseEntity
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public byte[] Password { get; set; }

        public byte[] PasswordKey { get; set; }
    }
}
*/