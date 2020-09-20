using System;
using System.ComponentModel.DataAnnotations;

namespace ApiPruebaSQlITE.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SuperHero { get; set; }
    }
}
