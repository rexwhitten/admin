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
    
    public partial class tblConsultant
    {
        public int ConsultantKey { get; set; }
        public string ConsultantFirstName { get; set; }
        public string ConsultantLastName { get; set; }
        public string ConsultantAddress { get; set; }
        public string ConsultantAddressCont { get; set; }
        public string ConsultantCity { get; set; }
        public string ConsultantState { get; set; }
        public string ConsultantCountry { get; set; }
        public string ConsultantZip { get; set; }
        public string ConsultantEmail { get; set; }
        public string ConsultantWebsite { get; set; }
        public string ConsultantLastAttended { get; set; }
        public string ConsultantHighestDegree { get; set; }
        public string ConsultantLanguage { get; set; }
        public string ConsultantLanguageOther { get; set; }
        public string ConsultantServices { get; set; }
        public string ConsultantServicesOther { get; set; }
        public string ConsultantOtherInformation { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Removed { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
