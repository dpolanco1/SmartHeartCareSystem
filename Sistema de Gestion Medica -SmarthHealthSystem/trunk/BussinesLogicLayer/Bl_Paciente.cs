using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using DataAccessLayer;
using System.Data;
using System.Windows.Forms;


namespace BussinesLogicLayer
{
    public class Bl_Paciente
    {

        private static Da_Paciente GetDaPersona()//metodo singleton
        {
            Da_Paciente daPersona = new Da_Paciente();
            return daPersona;
        }


        public static bool Insert(Ent_Paciente entPaciente)
        {
            //instancio el metodo
            Da_Paciente daPersona = GetDaPersona();

            //Validaciones De Lugar
            bool flag = false;

            if (entPaciente.Nombres.Equals(String.Empty) || entPaciente.Apellidos.Equals(String.Empty) || entPaciente.IDTipoIdentifacion.Equals(String.Empty) ||
                entPaciente.Identificacion.Equals(String.Empty) || entPaciente.FechaNacimiento.Equals(String.Empty) || entPaciente.Genero.Equals(String.Empty) ||
                entPaciente.TipoPaciente.Equals(String.Empty))

            { 
            
               flag = false;
            
            }else if ( Da_Paciente.Insert(entPaciente))
            
            {

                flag = true;

            }

            return flag;
        }

        public void Update(Ent_Paciente entPaciente)
        {

            //Validaciones De Lugar


            


        }

        public void Delete(Ent_Paciente entPaciente)
        {


        }

        public void Search(Ent_Paciente entPaciente)
        {


        }
      public static int ObtenerIDPacienteMax()

        {
            if (Da_Paciente.ObtenerIDPacienteMax() >= 0)
            {
                return Da_Paciente.ObtenerIDPacienteMax();

            }
            else 
            {

                return 1;
            }
             
        
        }

    }
}
