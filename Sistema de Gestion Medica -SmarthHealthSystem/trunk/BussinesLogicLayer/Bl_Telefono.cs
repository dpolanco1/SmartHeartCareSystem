using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using DataAccessLayer;

namespace BussinesLogicLayer
{
    public class Bl_Telefono
    {

        private static Da_Telefono GetDaTelefono()//metodo singleton
        {
            Da_Telefono daTelefono = new Da_Telefono();
            return daTelefono;
        }

        public static bool Insert(Ent_Telefono entTelefono)
        {
            //instancio el metodo
            Da_Telefono daTelefono = GetDaTelefono();

            //Validaciones De Lugar
            bool flag = false;

            if (entTelefono.IDPaciente.Equals(String.Empty) || entTelefono.Telefono.Equals(String.Empty) )

            {
             flag= false;
            
            }   else if (Da_Telefono.Insert(entTelefono))            
            {
                 
                 flag= true;
            }        

            return flag;


        }

        public void Update(Da_Telefono daTelefono)
        {

            //Validaciones De Lugar





        }

        public void Delete(Da_Telefono daTelefono)
        {


        }

        public void Search(Da_Telefono daTelefono)
        {


        }
    }
}
