using EntidadesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class Da_Consultas
    {
        public static bool InsertaConsulta(Ent_Consultas EntidadConsulta)
        {
            bool flag = false;

            try
            {

                //Utilizo la clase Command Insertar en un StroreProcedure
                SqlCommand command = new SqlCommand("sp_insertarconsulta", Da_Connection.Get);
                command.CommandType = CommandType.StoredProcedure;
                Da_Connection.Get.Open();
                command.Parameters.AddWithValue("@idmedico", EntidadConsulta.IDMedico);
                command.Parameters.AddWithValue("@idpaciente", EntidadConsulta.IDPaciente);
                command.Parameters.AddWithValue("@motivo", EntidadConsulta.Motivo);
                command.Parameters.AddWithValue("@diagnostico", EntidadConsulta.Diagnostico);
                command.Parameters.AddWithValue("@fechaconsulta", EntidadConsulta.Fecha);

                int succed = Convert.ToInt16(command.ExecuteNonQuery());

                if (succed > 0)
                    flag = true;
                else
                    flag = false;

            }
            catch (Exception err) { Console.WriteLine(err.Message); }
            finally
            {

                if (Da_Connection.Get.State != ConnectionState.Closed)
                {
                    Da_Connection.Get.Close();
                }

            }
            return flag;
        }
    }
}