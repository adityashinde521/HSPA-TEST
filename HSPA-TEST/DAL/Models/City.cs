using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    public class City
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is a mandatory field.")]
        [StringLength(15, MinimumLength = 2)]
        [RegularExpression(".*[a-zA-Z+.*", ErrorMessage = "Numeric values are not allowed.")]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Required]
        [Column(Order = 2)]
        public string Country { get; set; }
       

    }
}