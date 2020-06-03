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
    
    public partial class Cart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cart()
        {
            this.CartItems = new HashSet<CartItem>();
            this.Notices = new HashSet<Notice>();
        }
    
        public long CartID { get; set; }
        public int UserID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<long> SampleID { get; set; }
        public Nullable<System.DateTime> SampleTransmitTime { get; set; }
        public short CheckedOut { get; set; }
        public Nullable<System.DateTime> CheckedOutTime { get; set; }
        public short CheckedIn { get; set; }
        public Nullable<System.DateTime> CheckedInTime { get; set; }
        public short Urgency { get; set; }
        public string Location { get; set; }
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public short Status { get; set; }
        public string Items { get; set; }
        public Nullable<int> CheckedOutID { get; set; }
        public Nullable<System.DateTime> RequiredTime { get; set; }

        public double RequiredInterval
        {
            get
            {
                return RequiredTime != null ? RequiredTime.Value.Subtract(DateTime.Now).TotalMinutes : 4320;
            }
        }


        public Nullable<int> NumberRc { get; set; }
        public Nullable<int> NumberPl { get; set; }
        public Nullable<int> NumberPp { get; set; }
        public Nullable<int> NumberGs { get; set; }
    
        public virtual Member Member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartItem> CartItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notice> Notices { get; set; }

    }
}
