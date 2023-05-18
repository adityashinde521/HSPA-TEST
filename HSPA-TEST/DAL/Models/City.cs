using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}

/*using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    public class City : BaseEntity
    {
        public City(string name, string country)
        {
            this.Name = name;
            this.Country = country;

        }
        [Column(Order = 1)]
        public string Name { get; set; }

        [Required]
        [Column(Order = 2)]
        public string Country { get; set; }
    }
}
*/