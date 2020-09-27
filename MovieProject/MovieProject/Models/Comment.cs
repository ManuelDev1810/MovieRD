using System;
using System.ComponentModel.DataAnnotations;

namespace MovieProject.Models
{
    public class Comment
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}