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
                command.Parameters.Add(new SqlParameter("@Email", EntidadPersona.Email) { SqlDbType = SqlDbType.DateTime });
                command.Parameters.Add(new SqlParameter("@Notas", EntidadPersona.Observaciones) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Peso", EntidadPersona.Peso) { SqlDbType = SqlDbType.Decimal });
                command.Parameters.Add(new SqlParameter("@Altura", EntidadPersona.Altura) { SqlDbType = SqlDbType.Decimal });
                command.Parameters.Add(new SqlParameter("@Activo", EntidadPersona.Activo) { SqlDbType = SqlDbType.Bit });
                command.Parameters.Add(new SqlParameter("@EnvioMail", EntidadPersona.EnvioEmail) { SqlDbType = SqlDbType.Bit });
                
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
