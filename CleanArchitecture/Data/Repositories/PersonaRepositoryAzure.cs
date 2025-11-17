using Data.DataBase;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    internal class PersonaRepositoryAzure : IListadoPersonasRepository
    {
        public List<Persona> getListadoPersonas()
        {
            SqlConnection miConexion = new SqlConnection();

            List<Persona> listadoPersonas = new List<Persona>();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            Persona oPersona;

            miConexion.ConnectionString = Connection.GetConnectionString();
            try
            {

                miConexion.Open();

                miComando.CommandText = "SELECT * FROM personas";

                miComando.Connection = miConexion;

                miLector = miComando.ExecuteReader();


                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona = new Persona();

                        oPersona.id = (int)miLector["ID"];

                        oPersona.nombre = (string)miLector["Nombre"];

                        oPersona.apellidos = (string)miLector["Apellidos"];


                        //Si sospechamos que el campo puede ser Null en la BBDD

                        if (miLector["fechaNacimiento"] != System.DBNull.Value) { oPersona.fechaNac = (DateTime)miLector["FechaNacimiento"]; }

                        oPersona.direccion = (string)miLector["Direccion"];

                        oPersona.telefono = (string)miLector["Telefono"];

                        listadoPersonas.Add(oPersona);

                    }

                }

                miLector.Close();

                miConexion.Close();

            }
            catch (SqlException exSql)
            {

                throw exSql;

            }

            return listadoPersonas;
        }
    }
}
