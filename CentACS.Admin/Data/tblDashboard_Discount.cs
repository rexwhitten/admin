//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CentACS.Admin.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDashboard_Discount
    {
        public short DiscountKey { get; set; }
        public short OrganizationKey { get; set; }
        public short UserKey { get; set; }
        public decimal PercentOff { get; set; }
        public bool Active { get; set; }
        public bool Removed { get; set; }
        public System.DateTime DateCreated { get; set; }
        public short ModifiedBy { get; set; }
    }
}
