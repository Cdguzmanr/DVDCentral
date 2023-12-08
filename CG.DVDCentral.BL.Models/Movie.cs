﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.DVDCentral.BL.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        
        //[DisplayName("Movie Name")]
        public string? Description { get; set; }
        public int FormatId { get; set; }
        public int DirectorId { get; set; }
        public int RatingId { get; set; }
        public double Cost { get; set; }
        public int InStkQty { get; set; }
        public int Quantity { get; set; } = 1; // Amount of movies in the cart

        [DisplayName("Image")]
        public string ImagePath { get; set; } = "noImage.jpg";
        public List<Genre> Genres { get; set; } = new List<Genre>();

        [DisplayName("Rating")]
        public string? RatingDescription { get; set; }
        
        [DisplayName("Format")]
        public string? FormatDescription { get; set; }

        [DisplayName("Director Name")]
        public string? DirectorName { get; set;}
    }
}
