//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WOOW.Data
{
    using System;
    using System.Collections.Generic;
    
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
