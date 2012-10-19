using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using DataAccessLayer;


namespace BussinesLogicLayer
{
    public class Bl_Persona
    {

        private static Da_Persona GetDaPersona()//metodo singleton
        {
            Da_Persona daPersona = new Da_Persona();
            return daPersona;
        }

        public static bool Insert(Ent_Persona entPersona)
        {
            //instancio el metodo
            Da_Persona daPersona = GetDaPersona();

            //Validaciones De Lugar
            bool flag = false;

            if (entPersona.Nombres.Equals(String.Empty) || entPersona.Apellidos.Equals(String.Empty) || entPersona.IDTipoIdentifacion.Equals(String.Empty) ||
                entPersona.Identificacion.Equals(String.Empty) || entPersona.FechaNacimiento.Equals(String.Empty) || entPersona.Genero.Equals(String.Empty) ||
                entPersona.TipoPaciente.Equals(String.Empty))

            { 
            
               flag = false;
            
            }else if ( Da_Persona.Insert(entPersona))
            
            {

                flag = true;

            }

            return flag;
        }

        public void Update(Ent_Persona entPersona)
        {

            //Validaciones De Lugar


            


        }

        public void Delete(Ent_Persona entPersona)
        {


        }

        public void Search(Ent_Persona entPersona)
        {


        }



    }
}
