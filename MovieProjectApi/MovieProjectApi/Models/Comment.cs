using System;
using System.ComponentModel.DataAnnotations;

namespace MovieProjectApi.Models
{
    public class Comment
    {
        [Key]
        public Guid ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Movie Movie { get; set; }
    }
}
