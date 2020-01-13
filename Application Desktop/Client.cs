using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop
{
    class Client
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public virtual int VoituresID { get; set; }
        public virtual Voiture V { get; set; } // 
        public virtual ICollection<Voiture> Voitures { get; set; }
        public virtual Carte C{ get; set; }
        public virtual ICollection<Entreprise> Entreprises{ get; set; }
    }
}
