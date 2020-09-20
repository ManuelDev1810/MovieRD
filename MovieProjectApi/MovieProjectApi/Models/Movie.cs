using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieProjectApi.Models
{
    public enum Category
    {
        Action = 1,
        Comedy = 2,
        Drama = 3,
        Fantasy = 4,
        Horror = 5,
        Mystery = 6,
        Romance = 7,
        Thriller = 8
    }

    public enum Language
    {
        Mandarin = 1,
        Spanish = 2,
        English = 3,
        Hindi = 4
    }

    public class Movie
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string UrlVideo { get; set; }
        public string UrlLogo { get; set; }
        public decimal Rating { get; set; }
        public string Duration { get; set; }
        public int Views { get; set; }
        public bool IncludedSubtitles { get; set; }
        public DateTime Release { get; set; }
        public Language Language { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
