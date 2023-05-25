﻿using System.ComponentModel.DataAnnotations;

namespace HSPA_TEST.BLL.DTOs
{
    public class CityDto
    {

        [Required(ErrorMessage = "Name is mandatory field")]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(".*[a-zA-Z]+.*", ErrorMessage = "Only numerics are not allowed")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
