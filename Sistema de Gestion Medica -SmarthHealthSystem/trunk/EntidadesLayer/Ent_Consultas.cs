using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesLayer
{
  public  class Ent_Consultas
    {
        public string IDConsulta { get; set; }
        public DateTime Fecha { get; set; }
        public string IDMedico { get; set; }
        public string NombreMedico { get; set; }
        public string IDPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public string Motivo { get; set; }
        public string Diagnostico { get; set; }
    }
}
