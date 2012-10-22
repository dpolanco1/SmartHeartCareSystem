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
        public static DataSet SearchAll()
        {
            var listaPacientes = new List<Ent_Paciente>();
            DataSet dataset = new DataSet();
            try
            {

                SqlCommand Query = new SqlCommand("SELECT * FROM Pacientes ", Da_Connection.Get);
                Query.CommandType = CommandType.Text;
                Da_Connection.Get.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(Query);

                dataAdapter.Fill(dataset); 
                /*var dr = Query.ExecuteReader();
               

                while (dr.Read())
                {

                    listaPacientes.Add(new Ent_Paciente {

                        IDPaciente = dr.GetString(0),//dr.GetOrdinal("IDPaciente")
                        Nombres = dr.GetString(1),//dr.GetOrdinal("Nombres")
                        Apellidos = dr.GetString(2),//dr.GetOrdinal("Apellidos")
                        IDTipoIdentifacion = dr.GetInt32(3),//dr.GetOrdinal("IDTipoIdentifacion")
                        Identificacion = dr.GetString(4),//dr.GetOrdinal("Identificacion")
                        FechaNacimiento = dr.GetDateTime(5),//dr.GetOrdinal("FechaNacimiento")
                        IDNivelAcademico = dr.GetInt32(6),//dr.GetOrdinal("IDNivelAcademico")
                        IDOcupacion = dr.GetInt32(7),//dr.GetOrdinal("IDOcupacion")
                        Genero = dr.GetString(8),//dr.GetOrdinal("Genero")
                        EstadoCivil = dr.GetString(9),//dr.GetOrdinal("EstadoCivil")
                        TipoSangre = dr.GetString(10),//dr.GetOrdinal("TipoSangre")
                        TipoPaciente = dr.GetInt32(11),//dr.GetOrdinal("IDTipoPaciente")
                        NSS = dr.GetString(12),//dr.GetOrdinal("NSS")
                        Email = dr.GetString(13),//dr.GetOrdinal("Email")
                        IDNacionalidad = dr.GetInt32(14),//dr.GetOrdinal("IDNacionalidad")
                        IDPais = dr.GetInt32(15),//dr.GetOrdinal("IDPais")
                        IDRegion = dr.GetInt32(16),//dr.GetOrdinal("IDRegion")
                        IDProvincia = dr.GetInt32(17),//dr.GetOrdinal("IDProvincia")
                        IDSector = dr.GetInt32(18),//dr.GetOrdinal("IDSector")
                        FechaIngrero = dr.GetDateTime(19),//dr.GetOrdinal("FechaIngrero")
                        Peso = dr.GetDecimal(20),//dr.GetOrdinal("Peso")
                        Altura = dr.GetDecimal(21),//dr.GetOrdinal("Altura")
                        Activo = dr.GetBoolean(22),//dr.GetOrdinal("Activo")
                        EnvioEmail = dr.GetBoolean(23),//dr.GetOrdinal("EnvioEmail")
                        Observaciones = dr.GetString(24),//dr.GetOrdinal("Observaciones")
                    });

                }*/

                return dataset;
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

            return dataset;
        }//fin del Metodo
     
    }
}
