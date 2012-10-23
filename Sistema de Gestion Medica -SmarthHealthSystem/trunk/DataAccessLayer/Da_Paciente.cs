using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class Da_Paciente
    {

        public static bool Insert(Ent_Paciente EntidadPaciente) 
        {
            bool flag = false;

            try
                {

                    //Utilizo la clase Command Insertar en un StroreProcedure
                    SqlCommand command = new SqlCommand("Spr_InsertPersona", Da_Connection.Get);
                    command.CommandType = CommandType.StoredProcedure;

                    //Abro la conecxion 
                    Da_Connection.Get.Open();
                
                //Paso los valores para la tabla Pacientes.
                command.Parameters.Add(new SqlParameter("@Nombres", EntidadPaciente.Nombres) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Apellidos", EntidadPaciente.Apellidos) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@IDTipoIdentifacion", EntidadPaciente.IDTipoIdentifacion) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@Identificacion", EntidadPaciente.Identificacion) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@FechaNacimiento", EntidadPaciente.FechaNacimiento) { SqlDbType = SqlDbType.DateTime });
                command.Parameters.Add(new SqlParameter("@IDNivelAcademico", EntidadPaciente.IDNivelAcademico) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDOcupacion", EntidadPaciente.IDOcupacion) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@Genero", EntidadPaciente.Genero) { SqlDbType = SqlDbType.NChar });
                command.Parameters.Add(new SqlParameter("@EstadoCivil", EntidadPaciente.EstadoCivil) { SqlDbType = SqlDbType.NChar });
                command.Parameters.Add(new SqlParameter("@TipoSangre", EntidadPaciente.TipoSangre) { SqlDbType = SqlDbType.NChar });
                command.Parameters.Add(new SqlParameter("@IDTipoPaciente", EntidadPaciente.TipoPaciente) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@NSS", EntidadPaciente.NSS) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Email", EntidadPaciente.Email) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@IDNacionalidad", EntidadPaciente.IDNacionalidad) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDPais", EntidadPaciente.IDPais) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDRegion", EntidadPaciente.IDRegion) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDProvincia", EntidadPaciente.IDProvincia) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDSector", EntidadPaciente.IDSector) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@FechaIngrero", EntidadPaciente.FechaIngrero) { SqlDbType = SqlDbType.DateTime});
                command.Parameters.Add(new SqlParameter("@Peso", EntidadPaciente.Peso) { SqlDbType = SqlDbType.Decimal });
                command.Parameters.Add(new SqlParameter("@Altura", EntidadPaciente.Altura) { SqlDbType = SqlDbType.Decimal });
                command.Parameters.Add(new SqlParameter("@Activo", EntidadPaciente.Activo) { SqlDbType = SqlDbType.Bit });
                command.Parameters.Add(new SqlParameter("@EnvioEmail", EntidadPaciente.EnvioEmail) { SqlDbType = SqlDbType.Bit });
                command.Parameters.Add(new SqlParameter("@Observaciones", EntidadPaciente.Observaciones) { SqlDbType = SqlDbType.NVarChar });
               
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

            //retorno el resultado
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
        public static DataTable SearchAll()
        {

            DataTable dt = new DataTable();
      
            try
            {

                Da_Connection.Get.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("Spr_SearchAllPacientes", Da_Connection.Get);
               
                da.Fill(dt);
               
                return dt;
               

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            
            }

            finally
            {

                if (Da_Connection.Get.State != ConnectionState.Closed)
                {
                    Da_Connection.Get.Close();
                }

            }//fin del Finally
                
            return dt;
        }//fin del Metodo
     
    }
}
