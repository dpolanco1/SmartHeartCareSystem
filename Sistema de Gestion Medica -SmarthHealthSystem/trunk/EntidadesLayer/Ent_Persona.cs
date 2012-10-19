using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesLayer
{
    public class Ent_Persona
    {
          
         public string IDPersona {get;set;}
		 public  string Nombres {get;set;}
		 public  string Apellidos {get;set;}
		 public  int IDTipoIdentifacion {get;set;}
		 public  string Identificacion {get;set;}
		 public  DateTime FechaNacimiento {get;set;}
		 public  int IDNivelAcademico {get;set;}
         public int IDOcupacion { get; set; }
		 public  char Genero {get;set;}
		 public  char EstadoCivil {get;set;}
         public string TipoSangre { get; set; }
         public int TipoPaciente { get; set; }
         public char NSS { get; set; }
         public int Email { get; set; }
		 public  int IDNacionalidad {get;set;}
		 public  int IDPais {get;set;}
         public int IDRegion { get; set; }
		 public  int  IDProvincia {get;set;}
		 public  int IDSector {get;set;}
		 public  DateTime FechaIngrero {get;set;}
         public decimal Peso { get; set; }
         public decimal Altura { get; set; }
         public bool Activo { get; set; }
         public bool EnvioEmail { get; set; }
         public string Observaciones { get; set; }



    }
}
