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
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.Carts = new HashSet<Cart>();
            this.MemberRoles = new HashSet<MemberRole>();
        }
    
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsBarred { get; set; }
        public Nullable<int> BarredReasonId { get; set; }
        public Nullable<System.DateTime> BarredDate { get; set; }
        public Nullable<int> BarredPeriod { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string Specialty { get; set; }
        public Nullable<int> PositionId { get; set; }
        public Nullable<int> DesignationId { get; set; }
        public Nullable<int> ConsultantId { get; set; }
        public Nullable<int> GenderId { get; set; }
        public string PhoneNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberRole> MemberRoles { get; set; }
    }
}