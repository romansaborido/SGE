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
    public class PersonasRepository : IPersonasRepository
    {
        public bool deletePersonaById(int id)
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

                // Asignamos el comando a la conexion
                miComando.Connection = miConexion;


                // Creamos la consulta sql
                miComando.CommandText = "DELETE FROM Personas WHERE ID = " + id;

                // Ejecutamos la consulta


            } catch (SqlException SqlEx) { throw SqlEx; }



        }

        public Persona getPersonaById(int id)
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
                        persona.fechaNacimiento = (DateOnly)miLector["FechaNacimiento"];
                        persona.idDepartamento = (int)miLector["IDDepartamento"];
                    }
                }

                // Cerramos el lector y la conexion
                miLector.Close();
                miConexion.Close();
            
            // Capturamos y lanzamos la excepcion
            } catch (SqlException SqlEx) { throw SqlEx; }

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

            // Creamos un objeto Persona
            Persona persona = new Persona();

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
                        // Asignamos valores
                        persona.id = (int)miLector["ID"]; // Setter al ID de la persona??????
                        persona.nombre = (string)miLector["Nombre"];
                        persona.apellidos = (string)miLector["Apellidos"];
                        persona.telefono = (string)miLector["Telefono"];
                        persona.direccion = (string)miLector["Direccion"];
                        persona.foto = (string)miLector["Foto"];
                        persona.fechaNacimiento = (DateOnly)miLector["FechaNacimiento"];
                        persona.idDepartamento = (int)miLector["IDDepartamento"];

                        // Añadimos la persona a la lista
                        listaPersonas.Add(persona);
                    }
                }

                // Cerramos el lector y la conexion
                miLector.Close();
                miConexion.Close();

            // Capturamos y lanzamos la excepcion
            } catch (SqlException SqlEx) { throw SqlEx; }
            
            // Devolvemos el listado de personas
            return listaPersonas;
        }
    }
}
