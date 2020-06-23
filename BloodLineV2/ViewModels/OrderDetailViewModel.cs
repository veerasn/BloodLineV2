using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BloodLineV2.Models;
using System.ComponentModel.DataAnnotations;


namespace BloodLineV2.ViewModels
{
    public class OrderDetailViewModel
    {
        //Cart Details
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
        public Nullable<short> ReviewStatus { get; set; }
        public Nullable<int> ReviewedID { get; set; }
        public Nullable<System.DateTime> ReviewedTime { get; set; }

        //Transfusion Details
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

    }
}