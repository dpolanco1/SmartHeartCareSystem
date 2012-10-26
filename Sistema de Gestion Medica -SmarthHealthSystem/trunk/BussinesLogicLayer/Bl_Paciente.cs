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

            if (String.IsNullOrEmpty(entPaciente.Nombres) || String.IsNullOrEmpty(entPaciente.Apellidos))

            { 
            
               flag = false;
            
            }else if ( Da_Paciente.Insert(entPaciente))
            
            {

                flag = true;

            }

            return flag;
        }

        public static bool Update(Ent_Paciente entPaciente)
        {

            //instancio el metodo
            Da_Paciente daPersona = GetDaPersona();

            //Validaciones De Lugar
            bool flag = false;

            if (String.IsNullOrEmpty(entPaciente.Nombres) || String.IsNullOrEmpty(entPaciente.Apellidos))
            {

                flag = false;

            }
            else if (Da_Paciente.Update(entPaciente))
            {

                flag = true;

            }

            return flag;


        }

        public static bool Delete(Ent_Paciente entPaciente)
        {
            //instancio el metodo
            Da_Paciente daPersona = GetDaPersona();

            //Validaciones De Lugar
            bool flag = false;

            if (String.IsNullOrEmpty(entPaciente.IDPaciente))
            {

                flag = false;

            }
            else if (Da_Paciente.Delete(entPaciente))
            {

                flag = true;

            }

            return flag;

        }
        public static DataTable SearchAll()
        {
            return Da_Paciente.SearchAll();
        }
        public static int SearchIDPaciente()
        {
            return Da_Paciente.SearchIDPaciente();
        }
    }

}
