using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class Da_Persona
    {
     
        public bool Insertar(Ent_Persona ObjEnPersona) 
        {
            bool flag = false;
            
            try
            {
                //conecction = new DAConecction();
                SqlCommand command = new SqlCommand("Spr_InsertPersona", Da_Connection.Get);
                command.CommandType = CommandType.StoredProcedure;

                Da_Connection.Get.Open();

               /* command.Parameters.Add(new SqlParameter("@Nombres", ObjEnPersona.Nombres) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Apellidos", ObjEnPersona.Apellidos) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@IDTipoIdentifacion", ObjEnPersona.IDTipoIdentifacion) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@Identificacion", ObjEnPersona.Identificacion) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@NSS", ObjEnPersona.NSS) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@FechaNacimiento", ObjEnPersona.FechaNacimiento) { SqlDbType = SqlDbType.Date });
                command.Parameters.Add(new SqlParameter("@NivelAcademico", ObjEnPersona.NivelAcademico) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@FechaIngrero", ObjEnPersona.FechaIngrero) { SqlDbType = SqlDbType.Date });
                command.Parameters.Add(new SqlParameter("@Sexo", ObjEnPersona.Sexo) { SqlDbType = SqlDbType.Char });
                command.Parameters.Add(new SqlParameter("@EstadoCivil", ObjEnPersona.EstadoCivil) { SqlDbType = SqlDbType.Char });
                command.Parameters.Add(new SqlParameter("@Nacionalidad", ObjEnPersona.Nacionalidad) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@IDPais", ObjEnPersona.IDPais) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDProvincia", ObjEnPersona.IDProvincia) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDRegion", ObjEnPersona.IDRegion) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDSector", ObjEnPersona.IDSector) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@CodigoPostal", ObjEnPersona.CodigoPostal) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@TelefonoCasa", ObjEnPersona.TelefonoCasa) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@TelefonoOficina", ObjEnPersona.TelefonoOficina) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@TelOtro", ObjEnPersona.TelOtro) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@TelMovil", ObjEnPersona.TelMovil) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@NombreContacto", ObjEnPersona.NombreContacto) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@TeleContacto", ObjEnPersona.TeleContacto) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Direccion1", ObjEnPersona.Direccion1) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Direccion2", ObjEnPersona.Direccion2) { SqlDbType = SqlDbType.Decimal });
                command.Parameters.Add(new SqlParameter("@Email", ObjEnPersona.Email) { SqlDbType = SqlDbType.DateTime });
                command.Parameters.Add(new SqlParameter("@Notas", ObjEnPersona.Notas) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Estado", ObjEnPersona.Estado) { SqlDbType = SqlDbType.Bit });
                */
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
