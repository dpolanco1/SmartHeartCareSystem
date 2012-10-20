using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using DataAccessLayer;

namespace BussinesLogicLayer
{
    public class Bl_Contacto
    {

        private static Da_Contacto GetDaContacto()//metodo singleton
        {
            Da_Contacto daContacto = new Da_Contacto();
            return daContacto;
        }


        public static void Insert(Ent_Contacto entContacto)
        {
            //instancio el metodo
            Da_Contacto daContacto = GetDaContacto();

            //Validaciones De Lugar


            daContacto.Insert(entContacto);



        }

        public void Update(Ent_Paciente entPersona)
        {

            //Validaciones De Lugar





        }

        public void Delete(Ent_Paciente entPersona)
        {


        }

        public void Search(Ent_Paciente entPersona)
        {


        }
    }
}
