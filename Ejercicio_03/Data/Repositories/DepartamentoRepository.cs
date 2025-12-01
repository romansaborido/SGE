using Data.DataResources;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        public int addDepartamento(Departamento departamento)
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


                // Creamos la consulta Sql
                miComando.CommandText = "INSERT INTO Departamentos (Nombre) VALUES (@Nombre)";

                // Asignamos valor al parametro de la consulta
                miComando.Parameters.AddWithValue("@Nombre", departamento.nombre);

                // Ejecutamos la consulta y devolvemos su resultado
                return miComando.ExecuteNonQuery();
            }
            catch (SqlException sqlEx) 
            {
                Console.WriteLine(sqlEx.Message);
                throw;
            }
        }

        public int deleteDepartamento(int id)
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

                // Asignamos la conexion al comando
                miComando.Connection = miConexion;


                // Creamos la consulta Sql
                miComando.CommandText = "DELETE FROM Departamentos WHERE ID = @ID";

                // Asignamos el valor al parametro de la consulta
                miComando.Parameters.AddWithValue("@ID", id);

                // Ejecutamos la consulta y devolvemos su resultado
                return miComando.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
                throw;
            }
        }

        public Departamento getDepartamento(int id)
        {
            // Creamos la conexion
            SqlConnection miConexion = new SqlConnection();

            // Creamos el comando
            SqlCommand miComando = new SqlCommand();

            // Obtenemos el string de conexion
            miConexion.ConnectionString = Connection.GetConnectionString();

            // Creamos el lector
            SqlDataReader miLector;

            // Creamos el departamento
            Departamento departamento = new Departamento();


            try
            {
                // Abrimos la conexion
                miConexion.Open();

                // Asociamos el comando a la conexion
                miComando.Connection = miConexion;


                // Creamos la consulta Sql
                miComando.CommandText = "SELECT * FROM Departamentos WHERE ID = @ID";

                // Asignamos el parametro de la consulta
                miComando.Parameters.AddWithValue("@ID", id);

                // Ejecutamos y obtenemos el resultado de la consulta
                miLector = miComando.ExecuteReader();

                // Si la consulta devuelve algo
                if (miLector.HasRows)
                {
                    // Recorremos el resultado
                    while (miLector.Read())
                    {
                        // Asignamos valores
                        departamento.id = (int)miLector["ID"];
                        departamento.nombre = (string)miLector["Nombre"];
                    }
                }

                // Cerramos el lector y la conexion
                miLector.Close();
                miConexion.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            // Devolvemos el departamento
            return departamento;
        }

        public List<Departamento> getDepartamentos()
        {
            // Creamos la conexion
            SqlConnection miConexion = new SqlConnection();

            // Creamos el comando
            SqlCommand miComando = new SqlCommand();

            // Obtenemos la cadena de conexion
            miConexion.ConnectionString = Connection.GetConnectionString();

            // Creamos el lector
            SqlDataReader miLector;

            // Creamos la lista de departamentos que vamos a devolver
            List<Departamento> departamentos = new List<Departamento>();


            try
            {
                // Abrimos la conexion
                miConexion.Open();

                // Asignamos el comando a la conexion
                miComando.Connection = miConexion;

                // Creamos la consulta sql
                miComando.CommandText = "SELECT * FROM Departamentos";

                // Ejecutamos la consulta y obtenemos el resultado
                miLector = miComando.ExecuteReader();

                // Leemos el resultado
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        // Creamos el departamento que vamos a ir añadiendo
                        Departamento departamento = new Departamento();

                        // Obtenemos el departamento
                        departamento.id = (int)miLector["ID"];
                        departamento.nombre = (string)miLector["Nombre"];

                        // Añadimos el departamento al listado
                        departamentos.Add(departamento);
                    }
                }

                // Cerramos el comando
                miLector.Close();
                miConexion.Close();
            }
            catch (SqlException sqlEx) 
            {
                Console.WriteLine(sqlEx.Message);
                throw;
            }

            // Devolvemos los departamentos
            return departamentos;
        }

        public int updateDepartamento(int id, Departamento departamento)
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

                // Creamos la consulta sql
                miComando.CommandText = "UPDATE Departamentos SET Nombre = @Nombre WHERE ID = @Id";

                // Asignamos los valores a los parametros
                miComando.Parameters.AddWithValue("@Nombre", departamento.nombre);
                miComando.Parameters.AddWithValue("@Id", id);

                // Ejecutamos la consulta y devolvemos su resultado
                return miComando.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
                throw;
            }
        }
    }
}
