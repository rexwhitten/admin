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
    
    public partial class tblWorkplace_AnswersDemographics
    {
        public int Workplace_AnswersDemographicsKey { get; set; }
        public Nullable<int> QuestionnaireKey { get; set; }
        public Nullable<int> d1 { get; set; }
        public Nullable<int> d2 { get; set; }
        public Nullable<int> d3 { get; set; }
        public string d3_Other { get; set; }
        public Nullable<int> d4 { get; set; }
        public string d4_Other { get; set; }
        public Nullable<int> d5 { get; set; }
        public string d5_Other { get; set; }
        public Nullable<int> d6 { get; set; }
        public Nullable<int> d7 { get; set; }
        public Nullable<int> d8 { get; set; }
        public Nullable<int> d9 { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual tblMaster_Questionnaire tblMaster_Questionnaire { get; set; }
    }
}
