using System;
using System.Collections.Generic;

namespace ConsoleApp14.Models
{
    public partial class Rating
    {
        public int ProfileId { get; set; }
        public int MovieId { get; set; }
        public double Score { get; set; }
        public string Comment { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
