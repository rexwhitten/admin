namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblMaster360_QuestionnaireText
    {
        [Key]
        public int QuestionnaireTextKey { get; set; }

        public int? LanguageKey { get; set; }

        [StringLength(50)]
        public string Rater { get; set; }

        [StringLength(50)]
        public string Assessee { get; set; }

        [StringLength(200)]
        public string DevelopedBy { get; set; }

        [StringLength(50)]
        public string InstructionTitle { get; set; }

        [StringLength(2500)]
        public string Instructions { get; set; }

        [StringLength(100)]
        public string ExampleTitle { get; set; }

        [StringLength(50)]
        public string Example1 { get; set; }

        [StringLength(150)]
        public string Example1Detail { get; set; }

        [StringLength(50)]
        public string Example2 { get; set; }

        [StringLength(150)]
        public string Example2Detail { get; set; }

        [StringLength(50)]
        public string Example3 { get; set; }

        [StringLength(150)]
        public string Example3Detail { get; set; }

        [StringLength(50)]
        public string TrueText { get; set; }

        [StringLength(50)]
        public string FalseText { get; set; }

        [StringLength(2500)]
        public string MoreInstructions { get; set; }

        [StringLength(1000)]
        public string ImportanceIntro { get; set; }

        [StringLength(50)]
        public string SubmitButton { get; set; }

        [StringLength(50)]
        public string SaveButton { get; set; }

        [StringLength(50)]
        public string AboutButton { get; set; }

        [StringLength(50)]
        public string HelpButton { get; set; }

        [StringLength(150)]
        public string FooterText { get; set; }

        [StringLength(150)]
        public string ErrorText { get; set; }

        [StringLength(50)]
        public string AgreementImage { get; set; }

        [StringLength(1000)]
        public string AgreementImageText { get; set; }

        [StringLength(1000)]
        public string AgreementText { get; set; }

        [StringLength(50)]
        public string AgreementButton { get; set; }

        [StringLength(50)]
        public string AgreementLoadingText { get; set; }

        [StringLength(50)]
        public string SavingText { get; set; }

        [StringLength(50)]
        public string OtherText { get; set; }

        [StringLength(150)]
        public string CompleteText { get; set; }

        [StringLength(150)]
        public string SaveText { get; set; }

        [StringLength(150)]
        public string LoginError { get; set; }

        [StringLength(200)]
        public string CommentInstructions { get; set; }

        [StringLength(150)]
        public string Comments1Text { get; set; }

        [StringLength(150)]
        public string Comments2Text { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
