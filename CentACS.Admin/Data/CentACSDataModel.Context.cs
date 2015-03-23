﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CentACSAssessmentsEntities : DbContext
    {
        public CentACSAssessmentsEntities()
            : base("name=CentACSAssessmentsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<crypto> crypto { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblAdmin> tblAdmin { get; set; }
        public virtual DbSet<tblBook> tblBook { get; set; }
        public virtual DbSet<tblCertificationRegistration> tblCertificationRegistration { get; set; }
        public virtual DbSet<tblConsultant> tblConsultant { get; set; }
        public virtual DbSet<tblCountryCode> tblCountryCode { get; set; }
        public virtual DbSet<tblDashboard_Banner> tblDashboard_Banner { get; set; }
        public virtual DbSet<tblDashboard_Country> tblDashboard_Country { get; set; }
        public virtual DbSet<tblDashboard_CustomPrice> tblDashboard_CustomPrice { get; set; }
        public virtual DbSet<tblDashboard_Discount> tblDashboard_Discount { get; set; }
        public virtual DbSet<tblDashboard_Event> tblDashboard_Event { get; set; }
        public virtual DbSet<tblDashboard_ItemCode> tblDashboard_ItemCode { get; set; }
        public virtual DbSet<tblDashboard_Order> tblDashboard_Order { get; set; }
        public virtual DbSet<tblDashboard_OrderItem> tblDashboard_OrderItem { get; set; }
        public virtual DbSet<tblDashboard_OrderProject> tblDashboard_OrderProject { get; set; }
        public virtual DbSet<tblDashboard_Product> tblDashboard_Product { get; set; }
        public virtual DbSet<tblDashboard_ProductCategory> tblDashboard_ProductCategory { get; set; }
        public virtual DbSet<tblDashboard_ProductPrice> tblDashboard_ProductPrice { get; set; }
        public virtual DbSet<tblDashboard_State> tblDashboard_State { get; set; }
        public virtual DbSet<tblDashboard_TransactionUnit> tblDashboard_TransactionUnit { get; set; }
        public virtual DbSet<tblDashboard_TransactionUnitDetail> tblDashboard_TransactionUnitDetail { get; set; }
        public virtual DbSet<tblMaster_CareerGuiderModule> tblMaster_CareerGuiderModule { get; set; }
        public virtual DbSet<tblMaster_Company> tblMaster_Company { get; set; }
        public virtual DbSet<tblMaster_Competency> tblMaster_Competency { get; set; }
        public virtual DbSet<tblMaster_Competency_m2m_CompetencyGroup> tblMaster_Competency_m2m_CompetencyGroup { get; set; }
        public virtual DbSet<tblMaster_CompetencyGroup> tblMaster_CompetencyGroup { get; set; }
        public virtual DbSet<tblMaster_CompetencyType> tblMaster_CompetencyType { get; set; }
        public virtual DbSet<tblMaster_CompetencyType_m2m_Competency> tblMaster_CompetencyType_m2m_Competency { get; set; }
        public virtual DbSet<tblMaster_DeliveryMethod> tblMaster_DeliveryMethod { get; set; }
        public virtual DbSet<tblMaster_EmailContent> tblMaster_EmailContent { get; set; }
        public virtual DbSet<tblMaster_Language> tblMaster_Language { get; set; }
        public virtual DbSet<tblMaster_NormGroup> tblMaster_NormGroup { get; set; }
        public virtual DbSet<tblMaster_Organization> tblMaster_Organization { get; set; }
        public virtual DbSet<tblMaster_Product> tblMaster_Product { get; set; }
        public virtual DbSet<tblMaster_Project> tblMaster_Project { get; set; }
        public virtual DbSet<tblMaster_Project_m2m_Competency> tblMaster_Project_m2m_Competency { get; set; }
        public virtual DbSet<tblMaster_Project_m2m_LeaderModule> tblMaster_Project_m2m_LeaderModule { get; set; }
        public virtual DbSet<tblMaster_Project_m2m_Questionnaire> tblMaster_Project_m2m_Questionnaire { get; set; }
        public virtual DbSet<tblMaster_Project_m2m_TeamerModule> tblMaster_Project_m2m_TeamerModule { get; set; }
        public virtual DbSet<tblMaster_ProjectType> tblMaster_ProjectType { get; set; }
        public virtual DbSet<tblMaster_Questionnaire> tblMaster_Questionnaire { get; set; }
        public virtual DbSet<tblMaster_QuestionnaireType> tblMaster_QuestionnaireType { get; set; }
        public virtual DbSet<tblMaster_User> tblMaster_User { get; set; }
        public virtual DbSet<tblMaster_UserAddress> tblMaster_UserAddress { get; set; }
        public virtual DbSet<tblMaster_UserData> tblMaster_UserData { get; set; }
        public virtual DbSet<tblMaster360_Anchor> tblMaster360_Anchor { get; set; }
        public virtual DbSet<tblMaster360_Anchor_m2m_Organization> tblMaster360_Anchor_m2m_Organization { get; set; }
        public virtual DbSet<tblMaster360_Competency> tblMaster360_Competency { get; set; }
        public virtual DbSet<tblMaster360_Competency_m2m_Organization> tblMaster360_Competency_m2m_Organization { get; set; }
        public virtual DbSet<tblMaster360_QuestionnaireItem> tblMaster360_QuestionnaireItem { get; set; }
        public virtual DbSet<tblMaster360_QuestionnaireItem_m2m_Organization> tblMaster360_QuestionnaireItem_m2m_Organization { get; set; }
        public virtual DbSet<tblMaster360_QuestionnaireText> tblMaster360_QuestionnaireText { get; set; }
        public virtual DbSet<tblMaster360_Rater> tblMaster360_Rater { get; set; }
        public virtual DbSet<tblMaster360_RaterCategory> tblMaster360_RaterCategory { get; set; }
        public virtual DbSet<tblMaster360_RaterCategory_m2m_Organization> tblMaster360_RaterCategory_m2m_Organization { get; set; }
        public virtual DbSet<tblMaster360_Template> tblMaster360_Template { get; set; }
        public virtual DbSet<tblNews> tblNews { get; set; }
        public virtual DbSet<tblProject360_Approval> tblProject360_Approval { get; set; }
        public virtual DbSet<tblProject360_Questionnaire> tblProject360_Questionnaire { get; set; }
        public virtual DbSet<tblProject360_Rater> tblProject360_Rater { get; set; }
        public virtual DbSet<tblProject360_RaterResponse> tblProject360_RaterResponse { get; set; }
        public virtual DbSet<tblReportGenerationError> tblReportGenerationError { get; set; }
        public virtual DbSet<tblSchoolplace_AnswersConverted> tblSchoolplace_AnswersConverted { get; set; }
        public virtual DbSet<tblSchoolplace_AnswersDemographics> tblSchoolplace_AnswersDemographics { get; set; }
        public virtual DbSet<tblSchoolplace_AnswersInverted> tblSchoolplace_AnswersInverted { get; set; }
        public virtual DbSet<tblSchoolplace_AnswersOriginal> tblSchoolplace_AnswersOriginal { get; set; }
        public virtual DbSet<tblSchoolplace_AnswersRaw> tblSchoolplace_AnswersRaw { get; set; }
        public virtual DbSet<tblSchoolplace_AnswersStandard> tblSchoolplace_AnswersStandard { get; set; }
        public virtual DbSet<tblSchoolplace_AnswersStandardInverted> tblSchoolplace_AnswersStandardInverted { get; set; }
        public virtual DbSet<tblSchoolplace_AnswersStandardOptimized> tblSchoolplace_AnswersStandardOptimized { get; set; }
        public virtual DbSet<tblSchoolplace_LanguageCoverTOC> tblSchoolplace_LanguageCoverTOC { get; set; }
        public virtual DbSet<tblSchoolplace_LanguageTrait> tblSchoolplace_LanguageTrait { get; set; }
        public virtual DbSet<tblSchoolplace_LanguageTraitDetail> tblSchoolplace_LanguageTraitDetail { get; set; }
        public virtual DbSet<tblSchoolplace_Question> tblSchoolplace_Question { get; set; }
        public virtual DbSet<tblSchoolplace_QuestionnaireText> tblSchoolplace_QuestionnaireText { get; set; }
        public virtual DbSet<tblValues_AnswersConverted> tblValues_AnswersConverted { get; set; }
        public virtual DbSet<tblValues_AnswersDemographics> tblValues_AnswersDemographics { get; set; }
        public virtual DbSet<tblValues_AnswersInverted> tblValues_AnswersInverted { get; set; }
        public virtual DbSet<tblValues_AnswersOriginal> tblValues_AnswersOriginal { get; set; }
        public virtual DbSet<tblValues_AnswersPolarity> tblValues_AnswersPolarity { get; set; }
        public virtual DbSet<tblValues_AnswersRaw> tblValues_AnswersRaw { get; set; }
        public virtual DbSet<tblValues_AnswersStandard> tblValues_AnswersStandard { get; set; }
        public virtual DbSet<tblValues_LanguageAgencyCommunion> tblValues_LanguageAgencyCommunion { get; set; }
        public virtual DbSet<tblValues_LanguageAgencyInterpretation> tblValues_LanguageAgencyInterpretation { get; set; }
        public virtual DbSet<tblValues_LanguageBriefDefinition> tblValues_LanguageBriefDefinition { get; set; }
        public virtual DbSet<tblValues_LanguageCommunionInterpretation> tblValues_LanguageCommunionInterpretation { get; set; }
        public virtual DbSet<tblValues_LanguageConsistency> tblValues_LanguageConsistency { get; set; }
        public virtual DbSet<tblValues_LanguageFullDefinition> tblValues_LanguageFullDefinition { get; set; }
        public virtual DbSet<tblValues_LanguageHeaderFooter> tblValues_LanguageHeaderFooter { get; set; }
        public virtual DbSet<tblValues_LanguageInterpretExample> tblValues_LanguageInterpretExample { get; set; }
        public virtual DbSet<tblValues_LanguageIntroMain> tblValues_LanguageIntroMain { get; set; }
        public virtual DbSet<tblValues_LanguageIntroRightCol> tblValues_LanguageIntroRightCol { get; set; }
        public virtual DbSet<tblValues_LanguageJobFamilies> tblValues_LanguageJobFamilies { get; set; }
        public virtual DbSet<tblValues_LanguageJobFamiliesText> tblValues_LanguageJobFamiliesText { get; set; }
        public virtual DbSet<tblValues_LanguageLevelLegend> tblValues_LanguageLevelLegend { get; set; }
        public virtual DbSet<tblValues_LanguageLevelText> tblValues_LanguageLevelText { get; set; }
        public virtual DbSet<tblValues_LanguageMoralityValues> tblValues_LanguageMoralityValues { get; set; }
        public virtual DbSet<tblValues_LanguageMoralNonMoral> tblValues_LanguageMoralNonMoral { get; set; }
        public virtual DbSet<tblValues_LanguageSuggestions> tblValues_LanguageSuggestions { get; set; }
        public virtual DbSet<tblValues_LanguageTOCSubtitles> tblValues_LanguageTOCSubtitles { get; set; }
        public virtual DbSet<tblValues_LanguageTOCTitles> tblValues_LanguageTOCTitles { get; set; }
        public virtual DbSet<tblValues_LanguageValues> tblValues_LanguageValues { get; set; }
        public virtual DbSet<tblValues_LanguageValuesBalance> tblValues_LanguageValuesBalance { get; set; }
        public virtual DbSet<tblValues_LanguageValuesBalanceInterpretation> tblValues_LanguageValuesBalanceInterpretation { get; set; }
        public virtual DbSet<tblValues_LanguageValuesInLife> tblValues_LanguageValuesInLife { get; set; }
        public virtual DbSet<tblValues_LanguageValuesModel> tblValues_LanguageValuesModel { get; set; }
        public virtual DbSet<tblValues_LanguageValuesProfile> tblValues_LanguageValuesProfile { get; set; }
        public virtual DbSet<tblValues_Question> tblValues_Question { get; set; }
        public virtual DbSet<tblValues_QuestionDemographic> tblValues_QuestionDemographic { get; set; }
        public virtual DbSet<tblValues_QuestionDemographicDetail> tblValues_QuestionDemographicDetail { get; set; }
        public virtual DbSet<tblValues_QuestionnaireText> tblValues_QuestionnaireText { get; set; }
        public virtual DbSet<tblWebserviceError> tblWebserviceError { get; set; }
        public virtual DbSet<tblWorkplace_AnswersConverted> tblWorkplace_AnswersConverted { get; set; }
        public virtual DbSet<tblWorkplace_AnswersDemographics> tblWorkplace_AnswersDemographics { get; set; }
        public virtual DbSet<tblWorkplace_AnswersInverted> tblWorkplace_AnswersInverted { get; set; }
        public virtual DbSet<tblWorkplace_AnswersOriginal> tblWorkplace_AnswersOriginal { get; set; }
        public virtual DbSet<tblWorkplace_AnswersOriginalResearch> tblWorkplace_AnswersOriginalResearch { get; set; }
        public virtual DbSet<tblWorkplace_AnswersRaw> tblWorkplace_AnswersRaw { get; set; }
        public virtual DbSet<tblWorkplace_AnswersStandard> tblWorkplace_AnswersStandard { get; set; }
        public virtual DbSet<tblWorkplace_AnswersStandardInverted> tblWorkplace_AnswersStandardInverted { get; set; }
        public virtual DbSet<tblWorkplace_AnswersStandardOptimized> tblWorkplace_AnswersStandardOptimized { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorFitScore> tblWorkplace_LanguageCapacitorFitScore { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorHighPerformance> tblWorkplace_LanguageCapacitorHighPerformance { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorInterpretation> tblWorkplace_LanguageCapacitorInterpretation { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorIntro> tblWorkplace_LanguageCapacitorIntro { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorLowPerformance> tblWorkplace_LanguageCapacitorLowPerformance { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorReport> tblWorkplace_LanguageCapacitorReport { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorText> tblWorkplace_LanguageCapacitorText { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorTextIndicator> tblWorkplace_LanguageCapacitorTextIndicator { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorTraitEnergy> tblWorkplace_LanguageCapacitorTraitEnergy { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCompetencyName> tblWorkplace_LanguageCompetencyName { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultant> tblWorkplace_LanguageConsultant { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultantBlend> tblWorkplace_LanguageConsultantBlend { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultantBlendRatio> tblWorkplace_LanguageConsultantBlendRatio { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultantBlendText> tblWorkplace_LanguageConsultantBlendText { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultantIntepretationGuide> tblWorkplace_LanguageConsultantIntepretationGuide { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultantResponseBias> tblWorkplace_LanguageConsultantResponseBias { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultantTOC> tblWorkplace_LanguageConsultantTOC { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultantTraitReport> tblWorkplace_LanguageConsultantTraitReport { get; set; }
        public virtual DbSet<tblWorkplace_LanguageNarratorDetail> tblWorkplace_LanguageNarratorDetail { get; set; }
        public virtual DbSet<tblWorkplace_LanguageNarratorGroup> tblWorkplace_LanguageNarratorGroup { get; set; }
        public virtual DbSet<tblWorkplace_LanguageNarratorNoResearch> tblWorkplace_LanguageNarratorNoResearch { get; set; }
        public virtual DbSet<tblWorkplace_LanguageNarratorPartTwo> tblWorkplace_LanguageNarratorPartTwo { get; set; }
        public virtual DbSet<tblWorkplace_LanguageNarratorPartTwoIntro> tblWorkplace_LanguageNarratorPartTwoIntro { get; set; }
        public virtual DbSet<tblWorkplace_LanguageNarratorPartTwoValues> tblWorkplace_LanguageNarratorPartTwoValues { get; set; }
        public virtual DbSet<tblWorkplace_LanguageTrait> tblWorkplace_LanguageTrait { get; set; }
        public virtual DbSet<tblWorkplace_LanguageTraitDetail> tblWorkplace_LanguageTraitDetail { get; set; }
        public virtual DbSet<tblWorkplace_LanguageTraitTOC> tblWorkplace_LanguageTraitTOC { get; set; }
        public virtual DbSet<tblWorkplace_LeaderModule> tblWorkplace_LeaderModule { get; set; }
        public virtual DbSet<tblWorkplace_Question> tblWorkplace_Question { get; set; }
        public virtual DbSet<tblWorkplace_QuestionDemographic> tblWorkplace_QuestionDemographic { get; set; }
        public virtual DbSet<tblWorkplace_QuestionDemographicDetail> tblWorkplace_QuestionDemographicDetail { get; set; }
        public virtual DbSet<tblWorkplace_QuestionnaireText> tblWorkplace_QuestionnaireText { get; set; }
        public virtual DbSet<tblWorkplace_QuestionResearch> tblWorkplace_QuestionResearch { get; set; }
        public virtual DbSet<tblWorkplace_TeamerModule> tblWorkplace_TeamerModule { get; set; }
        public virtual DbSet<temp_demo_detail> temp_demo_detail { get; set; }
        public virtual DbSet<temp_questions> temp_questions { get; set; }
        public virtual DbSet<temp_traitdescription> temp_traitdescription { get; set; }
        public virtual DbSet<vwConsultantCountries> vwConsultantCountries { get; set; }
        public virtual DbSet<vwConsultantExport> vwConsultantExport { get; set; }
        public virtual DbSet<vwConsultantMap> vwConsultantMap { get; set; }
        public virtual DbSet<vwMaster_Assessees> vwMaster_Assessees { get; set; }
        public virtual DbSet<vwMaster_Project> vwMaster_Project { get; set; }
        public virtual DbSet<vwMaster_Questionnaire> vwMaster_Questionnaire { get; set; }
        public virtual DbSet<vwMaster360_ProjectSearch> vwMaster360_ProjectSearch { get; set; }
        public virtual DbSet<vwMasterExport> vwMasterExport { get; set; }
        public virtual DbSet<vwMasterTrainerCountries> vwMasterTrainerCountries { get; set; }
        public virtual DbSet<vwMasterTrainerMap> vwMasterTrainerMap { get; set; }
        public virtual DbSet<vwOrderInvoice> vwOrderInvoice { get; set; }
        public virtual DbSet<vwOrdersFilter> vwOrdersFilter { get; set; }
        public virtual DbSet<vwSchoolplace_LanguageTrait> vwSchoolplace_LanguageTrait { get; set; }
        public virtual DbSet<vwSchoolplaceExport> vwSchoolplaceExport { get; set; }
        public virtual DbSet<vwSearchAssessees> vwSearchAssessees { get; set; }
        public virtual DbSet<vwValuesExport> vwValuesExport { get; set; }
        public virtual DbSet<vwWorkplace_LanguageNarrator> vwWorkplace_LanguageNarrator { get; set; }
        public virtual DbSet<vwWorkplace_LanguageNarratorPartTwo> vwWorkplace_LanguageNarratorPartTwo { get; set; }
        public virtual DbSet<vwWorkplace_LanguageTrait> vwWorkplace_LanguageTrait { get; set; }
        public virtual DbSet<vwWorkplace_TeamerParticipants> vwWorkplace_TeamerParticipants { get; set; }
        public virtual DbSet<vwWorkplaceExport> vwWorkplaceExport { get; set; }
    }
}
