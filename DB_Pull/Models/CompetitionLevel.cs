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
    
    public partial class CompetitionLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompetitionLevel()
        {
            this.Students = new HashSet<Student>();
        }
    
        public short LEVEL_ID { get; set; }
        public string LEVEL_NAME { get; set; }
        public string LOWEST_GRADE { get; set; }
        public string HIGHEST_GRADE { get; set; }
        public string ACTIVE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
