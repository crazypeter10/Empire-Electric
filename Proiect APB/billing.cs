//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proiect_APB
{
    using System;
    using System.Collections.Generic;
    
    public partial class billing
    {
        public int bill_no { get; set; }
        public int cust_id { get; set; }
        public int account_id { get; set; }
        public string payment_mode { get; set; }
        public Nullable<System.DateTime> payment_date { get; set; }
        public Nullable<System.TimeSpan> payment_time { get; set; }
        public string rr_number { get; set; }
        public Nullable<double> bill_amount { get; set; }
        public Nullable<double> paid_amount { get; set; }
        public Nullable<double> excess_paid { get; set; }
        public string status { get; set; }
    
        public virtual account account { get; set; }
        public virtual customer customer { get; set; }
    }
}
