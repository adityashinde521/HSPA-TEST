using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    [Table("Photos")]
    public class Photo
    {
        public Guid Id { get; set; }

        //[Required]
        //public string PublicId { get; set; }
        public string ImageUrl { get; set; }
        //public bool IsPrimary { get; set; }
        public Guid PropertyId { get; set; }
        public Property Property { get; set; }

    }
}

/*
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    [Table("Photos")]
    public class Photo : BaseEntity
    {
        [Required]
        public string PublicId { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public bool IsPrimary { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }

    }
}
*/