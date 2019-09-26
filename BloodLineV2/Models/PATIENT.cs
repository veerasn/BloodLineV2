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
    
    public partial class PATIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PATIENT()
        {
            this.REQUESTS = new HashSet<REQUEST>();
            this.PATIENTS1 = new HashSet<PATIENT>();
        }
    
        public int PATID { get; set; }
        public string PATNUMBER { get; set; }
        public string REFHOSPNUMBER { get; set; }
        public string BENNUMBER { get; set; }
        public string INTNUMBER { get; set; }
        public Nullable<int> PATCREATIONDATE { get; set; }
        public Nullable<int> TITLEID { get; set; }
        public string NAME { get; set; }
        public string MAIDENNAME { get; set; }
        public string FIRSTNAME { get; set; }
        public string NAMESK { get; set; }
        public string MAIDENNAMESK { get; set; }
        public string FIRSTNAMESK { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string POSTALCODE { get; set; }
        public string COUNTRY { get; set; }
        public Nullable<System.DateTime> BIRTHDATE { get; set; }
        public string ETHNICORIGIN { get; set; }
        public string RELIGION { get; set; }
        public Nullable<byte> SEX { get; set; }
        public string TELEPHON { get; set; }
        public string FAX { get; set; }
        public Nullable<System.DateTime> INCOMMINGDATE { get; set; }
        public Nullable<System.DateTime> OUTPUTDATE { get; set; }
        public string ROOMNUMBER { get; set; }
        public string REFDOCTOR { get; set; }
        public string REFLOCATION { get; set; }
        public Nullable<byte> RECBYCNX { get; set; }
        public Nullable<System.DateTime> LASTUPDTESTDATE { get; set; }
        public Nullable<System.DateTime> LASTREVIEWDATE { get; set; }
        public Nullable<System.DateTime> DEATHDATE { get; set; }
        public Nullable<System.DateTime> RECALLDATE { get; set; }
        public string RECALLREQNUM { get; set; }
        public Nullable<System.DateTime> REMINDERDATE { get; set; }
        public Nullable<byte> REMINDERLEVEL { get; set; }
        public Nullable<int> REMINDERTIME1 { get; set; }
        public Nullable<int> REMINDERTIME2 { get; set; }
        public Nullable<int> REMINDERTIME3 { get; set; }
        public Nullable<int> PAYERPATID { get; set; }
        public Nullable<int> HOLDERPROFID { get; set; }
        public Nullable<int> INSUREDPROFID { get; set; }
        public Nullable<int> DOCID { get; set; }
        public Nullable<int> LEGALTIME { get; set; }
        public Nullable<byte> DISCOUNTRATE { get; set; }
        public string REFSSO { get; set; }
        public string REFHC { get; set; }
        public string SPECIFICBILLTXT { get; set; }
        public Nullable<byte> PATROW { get; set; }
        public Nullable<byte> PATRELATIONSHIP { get; set; }
        public Nullable<byte> EXEMPCODE { get; set; }
        public Nullable<int> INSNATURE { get; set; }
        public string HCSTATUS { get; set; }
        public Nullable<byte> RIGHTORIGIN { get; set; }
        public string SSOSTATUS { get; set; }
        public string BG_ABO { get; set; }
        public string BG_RHESUS { get; set; }
        public string BG_PHENOTYPES { get; set; }
        public string BG_KELL { get; set; }
        public Nullable<int> FIRSTITEMID { get; set; }
        public System.DateTime STARTVALIDDATE { get; set; }
        public Nullable<System.DateTime> ENDVALIDDATE { get; set; }
        public string STATCODE { get; set; }
        public string LISUSER { get; set; }
        public Nullable<System.DateTime> LISDATE { get; set; }
        public string LOGSESSION { get; set; }
        public string LOGUSERID { get; set; }
        public System.DateTime LOGDATE { get; set; }
        public string ACTIONTRACE { get; set; }
        public Nullable<byte> ERRONEOUSADDRESS { get; set; }
        public Nullable<int> SAFETYMEASURES { get; set; }
        public string TELEPHON2 { get; set; }
        public string EMAIL { get; set; }
        public Nullable<byte> VIP { get; set; }
        public Nullable<byte> SECRETRESULT { get; set; }
        public string CITIZENSHIP { get; set; }
        public Nullable<byte> TOBEREMINDED { get; set; }
        public string SSONUMBER { get; set; }
        public string DRIVERSLICENSENUM { get; set; }
        public Nullable<System.DateTime> BG_PRAIDATE { get; set; }
        public Nullable<short> PRECAUTION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUEST> REQUESTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PATIENT> PATIENTS1 { get; set; }
        public virtual PATIENT PATIENT1 { get; set; }
    }
}
