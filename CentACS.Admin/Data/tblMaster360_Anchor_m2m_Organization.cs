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
    
    public partial class tblMaster360_Anchor_m2m_Organization
    {
        public int Anchor_OrganizationKey { get; set; }
        public int AnchorKey { get; set; }
        public int OrganizationKey { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual tblMaster_Organization tblMaster_Organization { get; set; }
        public virtual tblMaster360_Anchor tblMaster360_Anchor { get; set; }
    }
}