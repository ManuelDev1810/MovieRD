using System;
using System.Collections.Generic;

namespace MovieProject.Models
{
    
    public class Movie
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Sinopsis { get; set; }
        public string UrlVideo { get; set; }
        public string UrlLogo { get; set; }
        public decimal Rating { get; set; }
        public string Duration { get; set; }
        public int Views { get; set; }
        public bool IncludedSubtitles { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Release { get; set; }
        public Language Language { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
