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
    
    public partial class PASSENGERS
    {
        public int ID_PASSENGER { get; set; }
        public string NAME { get; set; }
        public string SECOND_NAME { get; set; }
        public int ID_FLIGHT { get; set; }
    
        public virtual FLIGHTS FLIGHTS { get; set; }
    }
}
