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
    
    public partial class tariff
    {
        public tariff()
        {
            this.invoices = new HashSet<invoice>();
        }
    
        public int tariff_id { get; set; }
        public string tariff_type { get; set; }
        public string tariff_description { get; set; }
        public string status { get; set; }
    
        public virtual ICollection<invoice> invoices { get; set; }
    }
}
