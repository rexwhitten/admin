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
    
    public partial class tblReportGenerationError
    {
        public int ReportGenErrorKey { get; set; }
        public string ReportName { get; set; }
        public Nullable<System.DateTime> ErrorDate { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}
