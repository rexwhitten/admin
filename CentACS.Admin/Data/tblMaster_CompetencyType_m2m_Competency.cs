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
    
    public partial class tblMaster_CompetencyType_m2m_Competency
    {
        public int CompetencyType_Competency_Key { get; set; }
        public Nullable<int> CompentencyTypeKey { get; set; }
        public Nullable<int> CompetencyKey { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual tblMaster_Competency tblMaster_Competency { get; set; }
        public virtual tblMaster_CompetencyType tblMaster_CompetencyType { get; set; }
    }
}
