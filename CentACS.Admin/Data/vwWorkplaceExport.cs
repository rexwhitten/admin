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
    
    public partial class vwWorkplaceExport
    {
        public int QuestionnaireKey { get; set; }
        public string OrganizationName { get; set; }
        public string ConsultantFName { get; set; }
        public string ConsultantLName { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string ProductName { get; set; }
        public string GroupName { get; set; }
        public string QuestionLanguage { get; set; }
        public string ReportLanguage { get; set; }
        public string DeliveryMethod { get; set; }
        public Nullable<System.DateTime> DateQuestionnaireSent { get; set; }
        public Nullable<System.DateTime> DateCompleted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string JobCategory { get; set; }
        public string JobCategoryOther { get; set; }
        public string IndustrySegment { get; set; }
        public string IndustrySegmentOther { get; set; }
        public string Ethnicity { get; set; }
        public string EthnicityOther { get; set; }
        public string CountryIdentify { get; set; }
        public string CountryResidence { get; set; }
        public string HowLongCountryResidence { get; set; }
        public string FirstLanguage { get; set; }
        public Nullable<bool> IsCompleted { get; set; }
        public int Project_Questionnaire_Key { get; set; }
        public Nullable<int> UserKey { get; set; }
        public Nullable<int> OrganizationKey { get; set; }
        public string WebserviceTrackingKey { get; set; }
        public int ResearchSet { get; set; }
    }
}
