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
     
        public bool Insertar(Ent_Persona EntidadPersona,) 
        {
            bool flag = false;
            
            try
            {
                //conecction = new DAConecction();
                SqlCommand command = new SqlCommand("Spr_InsertPersona", Da_Connection.Get);
                command.CommandType = CommandType.StoredProcedure;

                Da_Connection.Get.Open();

                command.Parameters.Add(new SqlParameter("@Nombres", EntidadPersona.Nombres) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Apellidos", EntidadPersona.Apellidos) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@IDTipoIdentifacion", EntidadPersona.IDTipoIdentifacion) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@Identificacion", EntidadPersona.Identificacion) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@NSS", EntidadPersona.NSS) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@FechaNacimiento", EntidadPersona.FechaNacimiento) { SqlDbType = SqlDbType.Date });
                command.Parameters.Add(new SqlParameter("@NivelAcademico", EntidadPersona.IDNivelAcademico) { SqlDbType = SqlDbType.Int});
                command.Parameters.Add(new SqlParameter("@FechaIngrero", EntidadPersona.FechaIngrero) { SqlDbType = SqlDbType.Date });
                command.Parameters.Add(new SqlParameter("@Sexo", EntidadPersona.Genero) { SqlDbType = SqlDbType.Char });
                command.Parameters.Add(new SqlParameter("@EstadoCivil", EntidadPersona.EstadoCivil) { SqlDbType = SqlDbType.Char });
                command.Parameters.Add(new SqlParameter("@Nacionalidad", EntidadPersona.IDNacionalidad) { SqlDbType = SqlDbType.Int});
                command.Parameters.Add(new SqlParameter("@IDPais", EntidadPersona.IDPais) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDProvincia", EntidadPersona.IDProvincia) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDRegion", EntidadPersona.IDRegion) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDSector", EntidadPersona.IDSector) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@CodigoPostal", EntidadPersona.IDTelefono) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@TelefonoCasa", EntidadPersona.TelefonoCasa) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@TelefonoOficina", EntidadPersona.TelefonoOficina) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@TelOtro", EntidadPersona.TelOtro) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@TelMovil", EntidadPersona.TelMovil) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@NombreContacto", EntidadPersona.NombreContacto) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@TeleContacto", EntidadPersona.TeleContacto) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Direccion1", EntidadPersona.Direccion1) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Direccion2", EntidadPersona.Direccion2) { SqlDbType = SqlDbType.Decimal });
                command.Parameters.Add(new SqlParameter("@Email", EntidadPersona.Email) { SqlDbType = SqlDbType.DateTime });
                command.Parameters.Add(new SqlParameter("@Notas", EntidadPersona.Notas) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Estado", EntidadPersona.Estado) { SqlDbType = SqlDbType.Bit });
                
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
