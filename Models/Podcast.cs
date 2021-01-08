using System;
using System.ComponentModel.DataAnnotations;

namespace Podcastrz.Models
{
    public class Podcast
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]        
        public string Name { get; set; }
        
        public string Genre { get; set; }
        
        [Display(Name = "Hosted By")]        
        public string Host { get; set; }

        public string Details { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }
    }
}