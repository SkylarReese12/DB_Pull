//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_Pull.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LiabilityForm
    {
        public long STUDENT_ID { get; set; }
        public Nullable<bool> SUBMITTED { get; set; }
        public string FORM { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
