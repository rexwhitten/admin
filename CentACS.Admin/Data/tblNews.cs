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
    
    public partial class tblNews
    {
        public int NewsKey { get; set; }
        public string NewsTitle { get; set; }
        public string CustomUrl { get; set; }
        public Nullable<System.DateTime> NewsDate { get; set; }
        public Nullable<System.DateTime> DateDisplayStart { get; set; }
        public Nullable<System.DateTime> DateDisplayStop { get; set; }
        public string NewsBlurb { get; set; }
        public string NewsContent { get; set; }
        public string NewsImage { get; set; }
        public string NewsPDF { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> Removed { get; set; }
    }
}
