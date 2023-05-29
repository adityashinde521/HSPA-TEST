using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models.Authentication
{
    public class LoginRequestModel
    {
        [StringLength(50)]
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
