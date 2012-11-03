using DataAccessLayer;
using EntidadesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesLogicLayer
{
   public class BL_Consultas
    {
        private static Da_Consultas GetDaConsulta()//metodo singleton
        {
            Da_Consultas daConsulta = new Da_Consultas();
            return daConsulta;
        }


        public static bool Insert(Ent_Consultas entConsulta, ref string error)
        {
            //instancio el metodo
            Da_Consultas daConsulta = GetDaConsulta();
            error = "";
            //Validaciones De Lugar
            bool flag = false;
            try
            {
                if (String.IsNullOrEmpty(entConsulta.Motivo) || String.IsNullOrEmpty(entConsulta.Diagnostico) || entConsulta.IDPaciente <= 0 || entConsulta.IDMedico <= 0)
                {

                    flag = false;

                }
                else if (Da_Consultas.InsertaConsulta(entConsulta))
                {

                    flag = true;

                }
            }
            catch (Exception err) { error = err.Message; }
            return flag;
        }
    }
}
