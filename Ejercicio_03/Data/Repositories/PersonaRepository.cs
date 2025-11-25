using Data.DataResources;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;

namespace Data.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        public int addPersona(Persona persona)
        {
            // Creamos una conexion sql
            SqlConnection miConexion = new SqlConnection();

            // Creamos un comando para nuestra conexion
            SqlCommand miComando = new SqlCommand();

            // Inicializamos la conexion
            miConexion.ConnectionString = Connection.GetConnectionString();

            try 
            {
                // Abrimos la conexion
                miConexion.Open();

                // Asignamos el comando a la conexion
                miComando.Connection = miConexion;


                // Creamos la consulta Sql
                miComando.CommandText = "INSERT INTO Persona (Nombre, Apellidos, Telefono, Direccion, Foto, FechaNacimiento, IDDepartamento) VALUES (@Nombre, @Apellidos, @Telefono, @Direccion, @Foto, @FechaNacimiento, @IDDepartamento)";

                // Asignamos los valores de la persona a la consulta
                miComando.Parameters.AddWithValue("@Nombre", persona.nombre);
                miComando.Parameters.AddWithValue("@Apellidos", persona.apellidos);
                miComando.Parameters.AddWithValue("@Telefono", persona.telefono);
                miComando.Parameters.AddWithValue("@Direccion", persona.direccion);
                miComando.Parameters.AddWithValue("@Foto", persona.foto);
                miComando.Parameters.AddWithValue("@FechaNacimiento", persona.fechaNacimiento);
                miComando.Parameters.AddWithValue("IDDepartamento", persona.idDepartamento);

                // Ejecutamos la consulta y devolvemos su resultado
                return miComando.ExecuteNonQuery();

            }
            catch (SqlException SqlEx) 
            {
                Console.WriteLine(SqlEx.ToString());
                throw; 
            }
        }

        public int deletePersona(int id)
        {
            // Creamos la conexion
            SqlConnection miConexion = new SqlConnection();

            // Creamos el comando
            SqlCommand miComando = new SqlCommand();

            // Obtenemos el string de conexion
            miConexion.ConnectionString = Connection.GetConnectionString();

            // Añadimos el parametro ID a nuestro comando
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

            try
            {
                // Abrimos la conexion
                miConexion.Open();

                // Asignamos el comando a la conexion
                miComando.Connection = miConexion;


                // Creamos la consulta sql
                miComando.CommandText = "DELETE FROM Personas WHERE ID = @id";

                // Ejecutamos la consulta y devolvemos su resultado
                return miComando.ExecuteNonQuery();

            }
            catch (SqlException SqlEx) 
            {
                Console.WriteLine(SqlEx.ToString());
                throw;
            }



        }

        public Persona getPersona(int id)
        {
            // Creamos la conexion
            SqlConnection miConexion = new SqlConnection();

            // Creamos el comando
            SqlCommand miComando = new SqlCommand();

            // Creamos el lector
            SqlDataReader miLector;

            // Obtenemos el string de conexion
            miConexion.ConnectionString = Connection.GetConnectionString();

            // Creamos un objeto Persona
            Persona persona = new Persona();


            try
            {
                // Abrimos la conexion
                miConexion.Open();

                // Asignamos el comando a nuestra conexion
                miComando.Connection = miConexion;


                // Creamos la consulta sql
                miComando.CommandText = "SELECT * FROM Personas WHERE ID = " + id;

                // Ejecutamos la y obtenemos el resultado
                miLector = miComando.ExecuteReader();

                // Si la consulta devuelve algo
                if (miLector.HasRows)
                {
                    // Recorremos el resultado
                    while (miLector.Read())
                    {
                        // Asignamos valores
                        persona.id = (int)miLector["ID"];
                        persona.nombre = (string)miLector["Nombre"];
                        persona.apellidos = (string)miLector["Apellidos"];
                        persona.telefono = (string)miLector["Telefono"];
                        persona.direccion = (string)miLector["Direccion"];
                        persona.foto = (string)miLector["Foto"];
                        persona.foto = (string)miLector["Foto"];
                        DateTime fecha = (DateTime)miLector["FechaNacimiento"];
                        persona.idDepartamento = (int)miLector["IDDepartamento"];
                    }
                }

                // Cerramos el lector y la conexion
                miLector.Close();
                miConexion.Close();

                // Capturamos y lanzamos la excepcion
            }
            catch (SqlException SqlEx) 
            {
                Console.WriteLine(SqlEx.ToString());
                throw;
            }

            // Devolvemos la persona
            return persona;
        }

        public List<Persona> getPersonas()
        {
            // Creamos la conexion
            SqlConnection miConexion = new SqlConnection();

            // Creamos el comando
            SqlCommand miComando = new SqlCommand();

            // Creamos el lector
            SqlDataReader miLector;

            // Obtenemos el string de conexion
            miConexion.ConnectionString = Connection.GetConnectionString();

            // Creamos una lista de Personas
            List<Persona> listaPersonas = new List<Persona>();


            try
            {
                // Abrimos la conexion
                miConexion.Open();

                // Asignamos el comando a nuestra conexion
                miComando.Connection = miConexion;


                // Creamos la consulta Sql
                miComando.CommandText = "SELECT * FROM Personas";

                // Ejecutamos la consulta
                miLector = miComando.ExecuteReader();


                // Si la consulta devuelve algo
                if (miLector.HasRows)
                {
                    // Recorremos el resultado
                    while (miLector.Read())
                    {
                        // Creamos un objeto Persona
                        Persona persona = new Persona();

                        // Asignamos valores
                        persona.id = (int)miLector["ID"]; // Setter al ID de la persona??????
                        persona.nombre = (string)miLector["Nombre"];
                        persona.apellidos = (string)miLector["Apellidos"];
                        persona.telefono = (string)miLector["Telefono"];
                        persona.direccion = (string)miLector["Direccion"];
                        persona.foto = (string)miLector["Foto"];
                        DateTime fecha = (DateTime)miLector["FechaNacimiento"];
                        persona.fechaNacimiento = DateOnly.FromDateTime(fecha);
                        persona.idDepartamento = (int)miLector["IDDepartamento"];

                        // Añadimos la persona a la lista
                        listaPersonas.Add(persona);
                    }
                }

                // Cerramos el lector y la conexion
                miLector.Close();
                miConexion.Close();

                // Capturamos y lanzamos la excepcion
            }
            catch (SqlException SqlEx) 
            {
                Console.WriteLine(SqlEx.ToString());
                throw;
            }

            // Devolvemos el listado de personas
            return listaPersonas;
        }

        public int updatePersona(int id, Persona persona)
        {
            // Creamos la conexion
            SqlConnection miConexion = new SqlConnection();

            // Creamos el comando
            SqlCommand miComando = new SqlCommand();

            // Obtenemos el string de conexion
            miConexion.ConnectionString = Connection.GetConnectionString();

            try
            {
                // Abrimos la conexion
                miConexion.Open();

                // Asociamos el comando a la conexion
                miComando.Connection = miConexion;


                // Creamos la consulta
                miComando.CommandText = "UPDATE Persona SET " +
                                                        "Nombre = @Nombre, " +
                                                        "Apellidos = @Apellidos, " +
                                                        "Telefono = @Telefono, " +
                                                        "Direccion = @Direccion, " +
                                                        "Foto = @Foto, " +
                                                        "FechaNacimiento = @FechaNacimiento, " +
                                                        "IDDepartamento = @IDDepartamento " +
                                        "WHERE ID = @Id";

                // Asignamos los valores de la persona a la consulta
                miComando.Parameters.AddWithValue("@Id", id);
                miComando.Parameters.AddWithValue("@Nombre", persona.nombre);
                miComando.Parameters.AddWithValue("@Apellidos", persona.apellidos);
                miComando.Parameters.AddWithValue("@Telefono", persona.telefono);
                miComando.Parameters.AddWithValue("@Direccion", persona.direccion);
                miComando.Parameters.AddWithValue("@Foto", persona.foto);
                miComando.Parameters.AddWithValue("@FechaNacimiento", persona.fechaNacimiento);
                miComando.Parameters.AddWithValue("@IDDepartamento", persona.idDepartamento);

                // Ejecutamos la consulta y devolvemos su resultado
                return miComando.ExecuteNonQuery();
            }
            catch (SqlException SqlEx) 
            {
                Console.WriteLine(SqlEx.ToString());
                throw;
            }
        }
    }
}
