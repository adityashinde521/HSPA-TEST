using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    public class FurnishingType
    {
        
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}

/*using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    public class FurnishingType : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
*/