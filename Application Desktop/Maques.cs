using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop
{
    class Maques
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public virtual int VoituresID { get; set; }
        public virtual Voiture V { get; set; } // Une Marque a Au moin une Vpoiture
        public virtual ICollection<Voiture> Voitures { get; set; } // Chaque Marqu a une collection de voiture
    }
}
