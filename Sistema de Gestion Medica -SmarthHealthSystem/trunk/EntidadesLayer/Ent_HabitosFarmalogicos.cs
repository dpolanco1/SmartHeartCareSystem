using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesLayer
{
   public  class Ent_HabitosFarmalogicos
    {

        public bool AntiHipertensivos { get; set; }
        public bool AntiPlaquetarios { get; set; }
        public bool AntiCoagulantes { get; set; }
        public bool AntiArritmicos { get; set; }
        public bool Antibioticos { get; set; }
        public bool AntiInlamatorios { get; set; }
        public bool Esteroides { get; set; }
        public bool Otros { get; set; }
        public string Descripcion { get; set; }


    }
}
