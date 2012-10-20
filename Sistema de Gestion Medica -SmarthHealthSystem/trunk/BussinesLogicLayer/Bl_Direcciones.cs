using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using DataAccessLayer;

namespace BussinesLogicLayer
{
    public class Bl_Direcciones
    {
        private static Da_Direcciones GetDaDirecciones()//metodo singleton
        {
            Da_Direcciones daDirecciones = new Da_Direcciones();
            return daDirecciones;
        }



        public static bool Insert(Ent_Direcciones entDirecciones)
        {

            //instancio el metodo
            Da_Direcciones daDirecciones = GetDaDirecciones();

            //Validaciones De Lugar
            bool flag = false;

            if (entDirecciones.IDPaciente.Equals(String.Empty)  || entDirecciones.Direccion.Equals(String.Empty) )

            {
             flag= false;
            
            }   else if (Da_Direcciones.Insert(entDirecciones))            
            {
                 
                 flag= true;
            }        

            return flag;


        }

        public void Update(Ent_Paciente entDirecciones)
        {

            //Validaciones De Lugar





        }

        public void Delete(Ent_Paciente entDirecciones)
        {


        }

        public void Search(Ent_Paciente entDirecciones)
        {


        }
    }
}
