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
    
    public partial class tblMaster_EmailContent
    {
        public int EmailContentKey { get; set; }
        public Nullable<int> ProductKey { get; set; }
        public Nullable<int> LanguageKey { get; set; }
        public string Subject { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string LinkText { get; set; }
        public Nullable<bool> IsQuestionnaireEmail { get; set; }
        public Nullable<bool> IsPublic { get; set; }
        public Nullable<int> OrganizationKey { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    }
}
