using System;
using System.Collections.Generic;

namespace ConsoleApp14.Models
{
    public partial class Profile
    {
        public Profile()
        {
            Rating = new HashSet<Rating>();
        }

        public int ProfileId { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Rating> Rating { get; set; }
    }
}
