//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practice_modules.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SECOND_PILOTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECOND_PILOTS()
        {
            this.FLIGHTS = new HashSet<FLIGHTS>();
        }
    
        public int ID_SECOND_PILOT { get; set; }
        public string NAME { get; set; }
        public string SECOND_NAME { get; set; }
        public string AGE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FLIGHTS> FLIGHTS { get; set; }
    }
}