//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BloodLineV2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Interupt
    {
        public int InteruptID { get; set; }
        public string Prodnum { get; set; }
        public string Patnumber { get; set; }
        public Nullable<System.DateTime> interupt_time { get; set; }
        public Nullable<int> interupt_outcome { get; set; }
        public Nullable<System.DateTime> outcome_time { get; set; }
        public Nullable<int> interupt_user { get; set; }
        public Nullable<int> outcome_user { get; set; }
        public Nullable<int> interupt_reason { get; set; }
    
        public virtual Transfusion Transfusion { get; set; }
    }
}
