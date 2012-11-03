using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesLayer
{
    public class Ent_Consultas
    {
        public string IDConsulta { get; set; }
        public String Fecha { get { return DateTime.Today.ToShortDateString(); } }
        public int IDMedico { get; set; }
       
        public int IDPaciente { get; set; }
       
        public string Motivo { get; set; }
        public string Diagnostico { get; set; }
    }
}
