using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace HSPA_TEST.DAL.Models.Authentication
{
    public class RegisterRequestModel
    {    public class User : IdentityUser
    {
        // Custom properties for User entity
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }

        public string RoleName { get; set; }

        // Navigation property for UserRole
        public UserRole UserRole { get; set; }
    }
        public string ConfirmPassword { get; set; }


        [EnumDataType(typeof(Roles))]
        public string RoleAlloted { get; set; }

    }
}
