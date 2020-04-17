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
    
    public partial class Transfusion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transfusion()
        {
            this.Interupts = new HashSet<Interupt>();
        }
    
        public int TransfusionId { get; set; }
        public string Prodnum { get; set; }
        public string Patnumber { get; set; }
        public Nullable<int> pre_temp { get; set; }
        public Nullable<int> pre_pulse { get; set; }
        public Nullable<int> pre_bp_sys { get; set; }
        public Nullable<int> pre_bp_dia { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public Nullable<int> start_user { get; set; }
        public Nullable<System.DateTime> interupt_time { get; set; }
        public Nullable<int> interupt_reason { get; set; }
        public Nullable<int> interupt_outcome { get; set; }
        public Nullable<System.DateTime> outcome_time { get; set; }
        public Nullable<int> interupt_user { get; set; }
        public Nullable<int> post_temp { get; set; }
        public Nullable<int> post_pulse { get; set; }
        public Nullable<int> post_sys { get; set; }
        public Nullable<int> post_dia { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public Nullable<int> end_user { get; set; }
        public Nullable<int> current_status { get; set; }
        public Nullable<int> interupt_num { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interupt> Interupts { get; set; }
    }
}
