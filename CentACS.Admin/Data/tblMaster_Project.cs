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
    
    public partial class tblMaster_Project
    {
        public tblMaster_Project()
        {
            this.tblMaster_Project_m2m_Questionnaire = new HashSet<tblMaster_Project_m2m_Questionnaire>();
            this.tblProject360_Rater = new HashSet<tblProject360_Rater>();
            this.tblProject360_Questionnaire = new HashSet<tblProject360_Questionnaire>();
        }
    
        public int ProjectKey { get; set; }
        public Nullable<int> OldProjectID { get; set; }
        public Nullable<int> OrganizationKey { get; set; }
        public Nullable<int> UserKey { get; set; }
        public string ProjectName { get; set; }
        public Nullable<int> ProjectTypeKey { get; set; }
        public Nullable<int> ProductKey { get; set; }
        public Nullable<int> QuestionnaireTypeKey { get; set; }
        public Nullable<int> Questionnaire_LanguageKey_Default { get; set; }
        public Nullable<int> Report_LanguageKey_Default { get; set; }
        public Nullable<int> NormGroupKey_Default { get; set; }
        public Nullable<int> CompetencyTypeKey { get; set; }
        public Nullable<int> CompetencyGroupKey { get; set; }
        public Nullable<int> QuestionnaireDeliveryMethodKey { get; set; }
        public Nullable<int> ReportDeliveryMethodKey { get; set; }
        public Nullable<System.DateTime> ShipPickupDate { get; set; }
        public Nullable<bool> TraitNarratorReport { get; set; }
        public Nullable<bool> ShortTraitReport { get; set; }
        public Nullable<bool> TraitCapacitorReport { get; set; }
        public Nullable<bool> ConsultantReport { get; set; }
        public Nullable<bool> CareerGuider { get; set; }
        public Nullable<bool> Learner { get; set; }
        public Nullable<int> Teamer { get; set; }
        public bool ValuesReport { get; set; }
        public string TeamerReportName { get; set; }
        public string TeamerTeamName { get; set; }
        public string TeamerModuleKeys { get; set; }
        public Nullable<int> Leader { get; set; }
        public string LeaderReportName { get; set; }
        public string LeaderModuleKeys { get; set; }
        public string EmailQuestionnaireSubject { get; set; }
        public string EmailQuestionnaireText1 { get; set; }
        public string EmailQuestionnaireText2 { get; set; }
        public string EmailQuestionnaireText3 { get; set; }
        public string EmailReportSubject { get; set; }
        public string EmailReportText1 { get; set; }
        public string EmailReportText3 { get; set; }
        public Nullable<bool> IsWebservice { get; set; }
        public string WebserviceEventID { get; set; }
        public Nullable<bool> IsWebserviceComplete { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<int> ModifiedByKey { get; set; }
        public string ReportGUID { get; set; }
        public string TeamerReportFilename { get; set; }
        public bool Standard360 { get; set; }
        public System.DateTime WP360ResponseDate { get; set; }
        public int NumberOfAssessees { get; set; }
        public bool IncludeCGQuestions { get; set; }
        public int ResearchSet { get; set; }
    
        public virtual tblMaster_CompetencyGroup tblMaster_CompetencyGroup { get; set; }
        public virtual tblMaster_CompetencyType tblMaster_CompetencyType { get; set; }
        public virtual tblMaster_DeliveryMethod tblMaster_DeliveryMethod { get; set; }
        public virtual tblMaster_DeliveryMethod tblMaster_DeliveryMethod1 { get; set; }
        public virtual tblMaster_Language tblMaster_Language { get; set; }
        public virtual tblMaster_Language tblMaster_Language1 { get; set; }
        public virtual tblMaster_NormGroup tblMaster_NormGroup { get; set; }
        public virtual tblMaster_Product tblMaster_Product { get; set; }
        public virtual ICollection<tblMaster_Project_m2m_Questionnaire> tblMaster_Project_m2m_Questionnaire { get; set; }
        public virtual tblMaster_ProjectType tblMaster_ProjectType { get; set; }
        public virtual tblMaster_QuestionnaireType tblMaster_QuestionnaireType { get; set; }
        public virtual tblMaster_User tblMaster_User { get; set; }
        public virtual ICollection<tblProject360_Rater> tblProject360_Rater { get; set; }
        public virtual ICollection<tblProject360_Questionnaire> tblProject360_Questionnaire { get; set; }
    }
}
