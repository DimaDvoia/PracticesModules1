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
    
    public partial class AIRPORTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AIRPORTS()
        {
            this.AIRCONTROLLERS = new HashSet<AIRCONTROLLERS>();
            this.BUS = new HashSet<BUS>();
            this.CONTROLLERS = new HashSet<CONTROLLERS>();
            this.LOADERS = new HashSet<LOADERS>();
            this.PLAINES = new HashSet<PLAINES>();
        }
    
        public int ID_AIRPORT { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AIRCONTROLLERS> AIRCONTROLLERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUS> BUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTROLLERS> CONTROLLERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOADERS> LOADERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLAINES> PLAINES { get; set; }
    }
}