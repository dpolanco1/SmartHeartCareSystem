using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class Da_Telefono
    {
       
        public static bool Insert(Ent_Telefono EntidadTelefono)
        {
            bool flag = false;

                //conecction = new DAConecction();
                SqlCommand command = new SqlCommand("Spr_InsertTelefonos", Da_Connection.Get);
                command.CommandType = CommandType.StoredProcedure;

                  //Abro la conecxion
                Da_Connection.Get.Open();

                //utilizo un Objeto de tipo Transacction que maneje el insert
                SqlTransaction transaction;
                transaction = Da_Connection.BeginTransaction();
               
            try
            
            {
                command.Parameters.Add(new SqlParameter("@IDPersona", EntidadTelefono.IDPaciente) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@Telefono", EntidadTelefono.Telefono) { SqlDbType = SqlDbType.NVarChar });
                command.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception ex)
            {
                //Anulo la Transaccion
                transaction.Rollback();
                Console.WriteLine(ex);
            } // end catch
            finally
            {

                if (Da_Connection.Get.State != ConnectionState.Closed)
                {
                    Da_Connection.Get.Close();
                }

            }


            return flag;
        }//fin del Metodo Insert


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
