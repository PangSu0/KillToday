using System;
using System.Collections.Generic;

namespace ConsoleApp14.Models
{
    public partial class Genre
    {
        public Genre()
        {
            MovieGenre = new HashSet<MovieGenre>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MovieGenre> MovieGenre { get; set; }
    }
}
