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
    
    public partial class tblMaster_ProjectType
    {
        public tblMaster_ProjectType()
        {
            this.tblMaster_Project = new HashSet<tblMaster_Project>();
        }
    
        public int ProjectTypeKey { get; set; }
        public string TypeName { get; set; }
        public Nullable<bool> DemographicsIncluded { get; set; }
        public Nullable<int> Rank { get; set; }
        public Nullable<bool> AdminOnly { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual ICollection<tblMaster_Project> tblMaster_Project { get; set; }
    }
}
