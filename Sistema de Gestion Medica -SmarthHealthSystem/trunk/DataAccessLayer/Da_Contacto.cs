using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class Da_Contacto
    {

        public bool Insert(Ent_Contacto EntidadContacto)
        {
            bool flag = false;

            try
            {
                //conecction = new DAConecction();
                SqlCommand command = new SqlCommand("Spr_InsertContacto", Da_Connection.Get);
                command.CommandType = CommandType.StoredProcedure;

                Da_Connection.Get.Open();

                command.Parameters.Add(new SqlParameter("@IDPersona", EntidadContacto.IDPersona) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@Contacto", EntidadContacto.Contacto) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Direccion", EntidadContacto.Telefono) { SqlDbType = SqlDbType.NVarChar });
                command.ExecuteNonQuery();

                flag = true;
            }
            finally
            {

                if (Da_Connection.Get.State != ConnectionState.Closed)
                {
                    Da_Connection.Get.Close();
                }

            }


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
