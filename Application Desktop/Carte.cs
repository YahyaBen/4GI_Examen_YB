using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Desktop
{
    class Carte
    {
        int ID { get; set; }
        DateTime Date_Obt { get; set; }
        int IDClient { get; set; }
        public virtual Client C { get; set; }

    }
}
