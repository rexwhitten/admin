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
    
    public partial class tblProject360_Questionnaire
    {
        public int QuestionnaireKey { get; set; }
        public int ProjectKey { get; set; }
        public string QuestionnaireData { get; set; }
        public string CompetencyPairData { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public int ModifiedBy { get; set; }
        public bool Approved { get; set; }
        public int ApprovedBy { get; set; }
        public string ApprovedDate { get; set; }
    
        public virtual tblMaster_Project tblMaster_Project { get; set; }
    }
}
