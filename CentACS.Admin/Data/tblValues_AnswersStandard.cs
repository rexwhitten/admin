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
    
    public partial class tblValues_AnswersStandard
    {
        public int Values_AnswersStandardKey { get; set; }
        public int QuestionnaireKey { get; set; }
        public System.DateTime DateCreated { get; set; }
        public double Achievement { get; set; }
        public double Activity { get; set; }
        public double Beauty { get; set; }
        public double Competition { get; set; }
        public double Justice { get; set; }
        public double Health { get; set; }
        public double Helping { get; set; }
        public double Independence { get; set; }
        public double Intellect { get; set; }
        public double Materialism { get; set; }
        public double Pleasure { get; set; }
        public double Power { get; set; }
        public double Relationships { get; set; }
        public double Spirituality { get; set; }
        public double Stability { get; set; }
        public double Status { get; set; }
    
        public virtual tblMaster_Questionnaire tblMaster_Questionnaire { get; set; }
    }
}
