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

        public bool Insertar(Ent_Direcciones EntidadDirecciones)
        {
            bool flag = false;

            try
            {
                //conecction = new DAConecction();
                SqlCommand command = new SqlCommand("Spr_InsertDirecciones", Da_Connection.Get);
                command.CommandType = CommandType.StoredProcedure;

                Da_Connection.Get.Open();

                command.Parameters.Add(new SqlParameter("@IDPersona", EntidadDirecciones.IDPersona) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@TipoDireccion", EntidadDirecciones.TipoDireccion) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Direccion", EntidadDirecciones.Direccion) { SqlDbType = SqlDbType.NVarChar});
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
        public bool actualizar()
        {

            bool flag = false;

            return flag;

        }
        public bool eliminar()
        {
            bool flag = false;

            return flag;

        }
        public bool buscar()
        {
            bool flag = false;

            return flag;

        }
    }
}
