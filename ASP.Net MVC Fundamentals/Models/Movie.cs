using System;
using System.ComponentModel.DataAnnotations;

namespace ASP.Net_MVC_Fundamentals.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required, Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required, Display(Name = "Number In Stock")]
        public int Quantity { get; set; }
    }
}