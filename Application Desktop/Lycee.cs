//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application_Desktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lycee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lycee()
        {
            this.Demandes = new HashSet<Demande>();
        }
    
        public int ID { get; set; }
        public string Nom { get; set; }
        public Nullable<int> NbrPlacs { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Demande> Demandes { get; set; }
    }
}
