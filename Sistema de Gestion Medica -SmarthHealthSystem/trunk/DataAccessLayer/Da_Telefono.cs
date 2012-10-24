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
               
            try

            {

                //conecction = new DAConecction();
                SqlCommand command = new SqlCommand("Spr_InsertTelefonos", Da_Connection.Get);
                command.CommandType = CommandType.StoredProcedure;

                //Abro la conecxion
                Da_Connection.Get.Open();

                command.Parameters.Add(new SqlParameter("@Telefono", EntidadTelefono.Telefono) { SqlDbType = SqlDbType.NVarChar });
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
        }//fin del Metodo Insert


        public static bool Update(Ent_Telefono EntidadTelefono)
        {

            bool flag = false;

            try
            {

                //conecction = new DAConecction();
                SqlCommand command = new SqlCommand("Spr_UpdateTelefonos", Da_Connection.Get);
                command.CommandType = CommandType.StoredProcedure;

                //Abro la conecxion
                Da_Connection.Get.Open();

                command.Parameters.Add(new SqlParameter("@IDPaciente", EntidadTelefono.IDPaciente) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@Telefono", EntidadTelefono.Telefono) { SqlDbType = SqlDbType.NVarChar });
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
