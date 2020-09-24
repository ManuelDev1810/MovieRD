using System;
namespace MovieProject.Models
{
    public class Comment
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}