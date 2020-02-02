﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BBOrderEntities : DbContext
    {
        public BBOrderEntities()
            : base("name=BBOrderEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberRole> MemberRoles { get; set; }
        public virtual DbSet<Notice> Notices { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    
        public virtual int CartNew(Nullable<int> cartID, Nullable<int> userID, Nullable<System.DateTime> dateCreated, Nullable<bool> checkedOut, Nullable<int> urgency, string location, string patientID, string patientName, Nullable<int> status)
        {
            var cartIDParameter = cartID.HasValue ?
                new ObjectParameter("CartID", cartID) :
                new ObjectParameter("CartID", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var dateCreatedParameter = dateCreated.HasValue ?
                new ObjectParameter("DateCreated", dateCreated) :
                new ObjectParameter("DateCreated", typeof(System.DateTime));
    
            var checkedOutParameter = checkedOut.HasValue ?
                new ObjectParameter("CheckedOut", checkedOut) :
                new ObjectParameter("CheckedOut", typeof(bool));
    
            var urgencyParameter = urgency.HasValue ?
                new ObjectParameter("Urgency", urgency) :
                new ObjectParameter("Urgency", typeof(int));
    
            var locationParameter = location != null ?
                new ObjectParameter("Location", location) :
                new ObjectParameter("Location", typeof(string));
    
            var patientIDParameter = patientID != null ?
                new ObjectParameter("PatientID", patientID) :
                new ObjectParameter("PatientID", typeof(string));
    
            var patientNameParameter = patientName != null ?
                new ObjectParameter("PatientName", patientName) :
                new ObjectParameter("PatientName", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CartNew", cartIDParameter, userIDParameter, dateCreatedParameter, checkedOutParameter, urgencyParameter, locationParameter, patientIDParameter, patientNameParameter, statusParameter);
        }
    
        public virtual int InsertBBOrder(Nullable<int> cartID, Nullable<int> userID, Nullable<int> urgency, string location, string patientID, string patientName)
        {
            var cartIDParameter = cartID.HasValue ?
                new ObjectParameter("CartID", cartID) :
                new ObjectParameter("CartID", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var urgencyParameter = urgency.HasValue ?
                new ObjectParameter("Urgency", urgency) :
                new ObjectParameter("Urgency", typeof(int));
    
            var locationParameter = location != null ?
                new ObjectParameter("Location", location) :
                new ObjectParameter("Location", typeof(string));
    
            var patientIDParameter = patientID != null ?
                new ObjectParameter("PatientID", patientID) :
                new ObjectParameter("PatientID", typeof(string));
    
            var patientNameParameter = patientName != null ?
                new ObjectParameter("PatientName", patientName) :
                new ObjectParameter("PatientName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertBBOrder", cartIDParameter, userIDParameter, urgencyParameter, locationParameter, patientIDParameter, patientNameParameter);
        }
    }
}
