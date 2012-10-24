using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using DataAccessLayer;


namespace BussinesLogicLayer
{
   public class Bl_HistorialClinico
    {

     
        public static bool Insert(Ent_HistorialClinico entHistorialClinico)
        {
            bool flag = false;

            //Validaciones


            Da_HistorialClinico.Insert(entHistorialClinico);
            flag = true;
           

            return flag;

        }
        public bool Update()
        {

            bool flag = false;

            return flag;

        }
        public bool Delete()
        {
            bool flag = false;

            return flag;

        }
        public bool Search()
        {
            bool flag = false;

            return flag;

        }


    }
}
