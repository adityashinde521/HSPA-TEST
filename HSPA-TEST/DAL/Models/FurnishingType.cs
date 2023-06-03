using HSPA_TEST.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.DAL.Models
{
    public class FurnishingType
    {
        
        public Guid Id { get; set; }

        public string Name { get; set; }
    }

}
