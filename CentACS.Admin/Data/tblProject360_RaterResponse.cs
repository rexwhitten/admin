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
    
    public partial class tblProject360_RaterResponse
    {
        public int RaterResponseKey { get; set; }
        public int ProjectRaterKey { get; set; }
        public string ResponseData { get; set; }
        public string CompetencyData { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual tblProject360_Rater tblProject360_Rater { get; set; }
    }
}
