using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.App_Code.Attributes
{
    public enum TranslationTableType
    {
        A,
        B,
        C,
        D
    }


    [AttributeUsage(AttributeTargets.Class)]
    public class TranslationTableTypeAttribute : System.Attribute
    {
        public TranslationTableType TranslationType { get; set; }

        public TranslationTableTypeAttribute(TranslationTableType TranslationType)
        {
            this.TranslationType = TranslationType;
        }
    }
}