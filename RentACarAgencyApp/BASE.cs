//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACarAgency
{
    using System;
    using System.Collections.Generic;
    
    public partial class BASE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BASE()
        {
            this.AGENTS = new HashSet<AGENTS>();
            this.CAR = new HashSet<CAR>();
            this.MECHANICS = new HashSet<MECHANICS>();
        }
    
        public int ID_BASE { get; set; }
        public string B_NAME { get; set; }
        public string REGION { get; set; }
        public string CITY { get; set; }
        public string ADRESS { get; set; }
        public Nullable<int> PHONE_NUMBER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENTS> AGENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAR> CAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MECHANICS> MECHANICS { get; set; }
    }
}
