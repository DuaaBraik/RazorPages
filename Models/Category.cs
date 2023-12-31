﻿using System.ComponentModel.DataAnnotations;

namespace ProjectWithRazorPages.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(1, 100, ErrorMessage ="Display Order must be between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
