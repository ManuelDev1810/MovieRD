using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieProject.Models
{
    
    public class Movie
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Sinopsis { get; set; }
        [Required]
        public string UrlVideo { get; set; }
        [Required]
        public string UrlLogo { get; set; }
        [Required]
        public decimal Rating { get; set; }
        [Required]
        public string Duration { get; set; }
        public int Views { get; set; }
        [Required]
        public bool IncludedSubtitles { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime Release { get; set; }
        [Required]
        public Language Language { get; set; }
        [Required]
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
