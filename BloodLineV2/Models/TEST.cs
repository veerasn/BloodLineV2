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
    
    public partial class TEST
    {
        public double TESTID { get; set; }
        public string ACCESSNUMBER { get; set; }
        public double REQCREATIONDATE { get; set; }
        public string TESTCODE { get; set; }
        public Nullable<double> TESTCREDATE { get; set; }
        public Nullable<byte> RESTYPE { get; set; }
        public string RESULT { get; set; }
        public Nullable<byte> RESSTATUS { get; set; }
        public string COMMENTS { get; set; }
        public string TESTINGUSER { get; set; }
        public Nullable<System.DateTime> TESTINGDATE { get; set; }
        public string VALIDUSER { get; set; }
        public Nullable<System.DateTime> VALIDDATE { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual DICT_TESTS DICT_TESTS { get; set; }
        public virtual REQUEST REQUEST { get; set; }
    }
}
