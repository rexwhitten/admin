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
    
    public partial class tblWorkplace_AnswersStandardInverted
    {
        public int Workplace_AnswersStandardInvertedKey { get; set; }
        public Nullable<int> QuestionnaireKey { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<double> ni { get; set; }
        public Nullable<double> ei { get; set; }
        public Nullable<double> oi { get; set; }
        public Nullable<double> ai { get; set; }
        public Nullable<double> ci { get; set; }
        public Nullable<double> n1i { get; set; }
        public Nullable<double> n2i { get; set; }
        public Nullable<double> n3i { get; set; }
        public Nullable<double> n4i { get; set; }
        public Nullable<double> e1i { get; set; }
        public Nullable<double> e2i { get; set; }
        public Nullable<double> e3i { get; set; }
        public Nullable<double> e4i { get; set; }
        public Nullable<double> e5i { get; set; }
        public Nullable<double> e6i { get; set; }
        public Nullable<double> o1i { get; set; }
        public Nullable<double> o2i { get; set; }
        public Nullable<double> o3i { get; set; }
        public Nullable<double> o4i { get; set; }
        public Nullable<double> a1i { get; set; }
        public Nullable<double> a2i { get; set; }
        public Nullable<double> a3i { get; set; }
        public Nullable<double> a4i { get; set; }
        public Nullable<double> c1i { get; set; }
        public Nullable<double> c2i { get; set; }
        public Nullable<double> c3i { get; set; }
        public Nullable<double> c4i { get; set; }
        public Nullable<double> c5i { get; set; }
    
        public virtual tblMaster_Questionnaire tblMaster_Questionnaire { get; set; }
    }
}