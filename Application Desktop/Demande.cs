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
    
    public partial class Demande
    {
        public int ID { get; set; }
        public Nullable<int> Lycee_id { get; set; }
        public Nullable<int> Professeur_id { get; set; }
        public Nullable<System.DateTime> Date_Demande { get; set; }
    
        public virtual Lycee Lycee { get; set; }
        public virtual Professeur Professeur { get; set; }
    }
}
