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
        public int REQTESTID { get; set; }
        public Nullable<int> CHAPID { get; set; }
        public int TESTID { get; set; }
        public Nullable<int> STNID { get; set; }
        public int REQUESTID { get; set; }
        public int LISTESTID { get; set; }
        public Nullable<int> TESTORDER { get; set; }
        public Nullable<byte> DEPTH { get; set; }
        public string TXTCOLLCOND { get; set; }
        public Nullable<byte> URGENT { get; set; }
        public Nullable<byte> NOTPRINTABLE { get; set; }
        public Nullable<byte> VALIDATIONCAUSE { get; set; }
        public string VALIDATIONINITIALS { get; set; }
        public Nullable<byte> VALIDATIONSTATUS { get; set; }
        public Nullable<byte> RESTYPE { get; set; }
        public string RESVALUE { get; set; }
        public Nullable<byte> RESSTATUS { get; set; }
        public Nullable<System.DateTime> RESUPDDATE { get; set; }
        public Nullable<System.DateTime> LASTUPDTESTDATE { get; set; }
        public Nullable<int> CODEDRESULTID { get; set; }
        public string MINIMUM { get; set; }
        public string MAXIMUM { get; set; }
        public string TESTURL { get; set; }
        public Nullable<int> SAMPLEID { get; set; }
        public string LOGUSERID { get; set; }
        public System.DateTime LOGDATE { get; set; }
        public Nullable<byte> SECRETTEST { get; set; }
        public Nullable<byte> UPDSTATUS { get; set; }
        public Nullable<byte> BINDATALINK { get; set; }
        public string ORDERPLACERNUMBER { get; set; }
        public string ORDERFILLERNUMBER { get; set; }
        public Nullable<int> LABOID { get; set; }
        public Nullable<int> INSTPERI { get; set; }
        public Nullable<int> INSTNUM { get; set; }
        public string TECHNICALINITIALS { get; set; }
        public Nullable<byte> CREATEDONTDR { get; set; }
        public string INST_IDENTIFIER { get; set; }
        public Nullable<byte> RERUN { get; set; }
        public Nullable<System.DateTime> VALIDATIONDATE { get; set; }
        public Nullable<System.DateTime> FIRSTVALIDATIONDATE { get; set; }
    
        public virtual REQUEST REQUEST { get; set; }
    }
}
