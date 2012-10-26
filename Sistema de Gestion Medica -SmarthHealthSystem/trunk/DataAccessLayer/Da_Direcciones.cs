using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class Da_Direcciones
    {


            public static bool Insert(Ent_Direcciones EntidadDirecciones)
        {
           
            bool flag = false;


                try
                {

                    //Utilizo la clase Command Insertar en un StroreProcedure
                    SqlCommand command = new SqlCommand("Spr_InsertDirecciones", Da_Connection.Get);
                    command.CommandType = CommandType.StoredProcedure;

                    //Abro la conecxion 
                    Da_Connection.Get.Open();

                command.Parameters.Add(new SqlParameter("@Direccion", EntidadDirecciones.Direccion) { SqlDbType = SqlDbType.NVarChar});
                //Ejecuto el Query
                command.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception ex)
            {
    
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

        }
        public static bool Update(Ent_Direcciones EntidadDirecciones)
        {
            bool flag = false;


            try
            {

                //Utilizo la clase Command Insertar en un StroreProcedure
                SqlCommand command = new SqlCommand("Spr_UpdateDirecciones", Da_Connection.Get);
                command.CommandType = CommandType.StoredProcedure;

                //Abro la conecxion 
                Da_Connection.Get.Open();

                command.Parameters.Add(new SqlParameter("@IDDireccion", EntidadDirecciones.IDDireccion) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@IDPaciente", EntidadDirecciones.IDPaciente) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Direccion", EntidadDirecciones.Direccion) { SqlDbType = SqlDbType.NVarChar });
                //Ejecuto el Query
                command.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception ex)
            {

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

        }
        public static bool Delete(Ent_Direcciones EntidadDirecciones)
        {
            bool flag = false;


            try
            {

                //Utilizo la clase Command Insertar en un StroreProcedure
                SqlCommand command = new SqlCommand("Spr_DeleteDirecciones", Da_Connection.Get);
                command.CommandType = CommandType.StoredProcedure;

                //Abro la conecxion 
                Da_Connection.Get.Open();

                command.Parameters.Add(new SqlParameter("@IDPaciente", EntidadDirecciones.IDPaciente) { SqlDbType = SqlDbType.NVarChar });
                //Ejecuto el Query
                command.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception ex)
            {

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

        }
        public bool Search()
        {
            bool flag = false;

            return flag;

        }
    }
}
