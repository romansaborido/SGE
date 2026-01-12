using Data.ConnectionResources;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        public List<IdPersonaDepartamentoDTO> getIds()
        {
            // Lista donde almacenaremos los ids de persona y departamento
            List<IdPersonaDepartamentoDTO> idsPersonaDepartamento = new List<IdPersonaDepartamentoDTO>();

            // Creamos la conexion
            SqlConnection conexion = new SqlConnection();

            // Creamos el comando
            SqlCommand comando = new SqlCommand();

            // Inicializamos la conexion
            conexion.ConnectionString = Connection.GetConnectionString();

            try
            {
                // Abrimos la conexion
                conexion.Open();

                // Asociamos el comando a la conexion
                comando.Connection = conexion;

                // Definimos la consulta SQL
                comando.CommandText = "SELECT IdPersona, IdDepartamento FROM Personas";

                // Ejecutamos el comando y obtenemos los datos
                SqlDataReader reader = comando.ExecuteReader();

                // Recorremos los registros y vamos creando los DTOs y agregandolos a la lista
                while (reader.Read())
                {
                    IdPersonaDepartamentoDTO dto = new IdPersonaDepartamentoDTO((int)reader["Id"], (int)reader["IdDepartamento"]);
                    idsPersonaDepartamento.Add(dto);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            // Devolvemos la lista con los ids
            return idsPersonaDepartamento;
        }

        public List<Persona> getPersonas()
        {
            // Lista donde almacenaremos las personas
            List<Persona> personas = new List<Persona>();

            // Creamos el comando
            SqlCommand comando = new SqlCommand();

            // Creamos la conexion
            SqlConnection conexion = new SqlConnection();

            // Inicializamos la conexion
            conexion.ConnectionString= Connection.GetConnectionString();

            try
            {
                // Abrimos la conexion
                conexion.Open();

                // Asignamos el comando a la conexion
                comando.Connection= conexion;

                // Creamos la consulta SQL
                comando.CommandText = "SELECT * FROM Personas";

                // Ejecutamos la consulta y obtenemos los resultados
                SqlDataReader reader = comando.ExecuteReader();

                // Recorremos los registros
                while (reader.Read()) 
                {

                    // Creamos la persona
                    Persona persona = new Persona();

                    // Asignamos los valores
                    persona.id = (int)reader["ID"];
                    persona.nombre = (string)reader["Nombre"];
                    persona.apellidos = (string)reader["Apellidos"];
                    persona.telefono = (string)reader["Telefono"];
                    persona.direccion = (string)reader["Direccion"];
                    persona.foto = (string)reader["Foto"];
                    DateTime fecha = (DateTime)reader["FechaNacimiento"];
                    persona.fechaNacimiento = DateOnly.FromDateTime(fecha);
                    persona.idDepartamento = (int)reader["IDDepartamento"];

                    // Añadimos la persona a la lista
                    personas.Add(persona);

                }
            }
            catch (SqlException ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            // Devolvemos la lista de personas
            return personas;
        }
    }
}
