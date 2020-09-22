using System;
namespace MovieProject.Models
{
    public class Comment
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Guid MovieId { get; set; }
    }
}