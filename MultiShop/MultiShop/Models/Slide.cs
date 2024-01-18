﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MultiShop.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set;}
        public int Order { get; set; }  
        public string? Activated { get; set; }
        public int SlideTo { get; set; } 
        public string? SlidesBtn { get; set; }
        

    }
}
