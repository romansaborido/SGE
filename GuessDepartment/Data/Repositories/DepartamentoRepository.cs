using Data.ConnectionResources;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        public Departamento getDepartamentoById(int id)
        {
            // Creamos el departamento a devolver
            Departamento departamento = new Departamento();

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

                // Creamos la consulta SQL
                comando.CommandText = "SELECT * FROM Departamentos WHERE Id = " + id;

                // Ejecutamos la consulta y obtenemos el resultado
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Asignamos los valores
                    departamento.id = (int)reader["Id"];
                    departamento.nombre = (string)reader["Nombre"];
                }
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
            // Creamos la lista de departamentos a devolver
            List<Departamento> departamentos = new List<Departamento>();

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

                // Creamos la consulta SQL
                comando.CommandText = "SELECT * FROM Departamentos";

                // Ejecutamos y obtenemos los resultados de la consulta
                SqlDataReader reader = comando.ExecuteReader();

                // Leemos los resultados
                while (reader.Read())
                {
                    // Creamos el departamento que vamos a ir añadiendo
                    Departamento departamento = new Departamento();

                    // Obtenemos el departamento
                    departamento.id = (int)reader["ID"];
                    departamento.nombre = (string)reader["Nombre"];

                    // Añadimos el departamento al listado
                    departamentos.Add(departamento);
                }

                // Devolvemos el listado
                return departamentos;

            }
            catch (SqlException ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
