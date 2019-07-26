using System;
using System.Collections.Generic;

namespace ConsoleApp14.Models
{
    public partial class MovieGenre
    {
        public int GenreId { get; set; }
        public int MovieId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
