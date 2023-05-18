using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    public class PropertyType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

/*using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    public class PropertyType : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
*/