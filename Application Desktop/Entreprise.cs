using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop
{
    class Entreprise
    {
        int ID { get; set; }
        int Raison { get; set; }
        int Fix { get; set; }
        int Fax { get; set; }
        public virtual Client C { get; set; }
        public virtual ICollection<Client> Entreprises { get; set; }
    }
}
