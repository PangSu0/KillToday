using System;
using System.Collections.Generic;

namespace ConsoleApp14.Models
{
    public partial class Movie
    {
        public Movie()
        {
            MovieGenre = new HashSet<MovieGenre>();
            Rating = new HashSet<Rating>();
        }

        public int MovieId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<MovieGenre> MovieGenre { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
    }
}
