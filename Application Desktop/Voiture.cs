using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop
{
    class Voiture
    {
        public int ID { get; set; }
        public string Matricule{ get; set; }
        public string Couleur { get; set; }
        public virtual Maques M { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
