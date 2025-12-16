using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories
{
    public class PlantaRepository : IPlantaRepository
    {
        #region atributos
        private List<Planta> _listadoPlantas;
        #endregion

        #region constructores
        public PlantaRepository() {
            _listadoPlantas = new List<Planta>() {
                new Planta {
                    id = 1,
                    nombre = "Ficus",
                    descripcion = "Planta de interior resistente y decorativa",
                    precio = 25.99,
                    idCategoria = 1
                },
                new Planta
                {
                    id = 2,
                    nombre = "Monstera",
                    descripcion = "Planta tropical de hojas grandes",
                    precio = 32.50,
                    idCategoria = 1
                },

                new Planta
                {
                    id = 3,
                    nombre = "Rosal",
                    descripcion = "Planta de exterior con flores aromáticas",
                    precio = 18.75,
                    idCategoria = 2
                },
                new Planta
                {
                    id = 4,
                    nombre = "Lavanda",
                    descripcion = "Planta aromática ideal para jardines",
                    precio = 15.00,
                    idCategoria = 2
                },
                new Planta
                {
                    id = 5,
                    nombre = "Aloe Vera",
                    descripcion = "Suculenta con propiedades medicinales",
                    precio = 12.30,
                    idCategoria = 3
                },
                new Planta
                {
                    id = 6,
                    nombre = "Echeveria",
                    descripcion = "Suculenta ornamental de fácil cuidado",
                    precio = 9.99,
                    idCategoria = 3
                }
            };
        }
        #endregion

        #region metodos
        // Devuelve 0 si no se ha podido modificar o el ID de la planta modificada
        public int cambiarPrecio(int idPlanta, double nuevoPrecio)
        {
            int res = 0;

            foreach (Planta planta in _listadoPlantas)
            {
                if (planta.id == idPlanta) { planta.precio = nuevoPrecio; }
                res = idPlanta;
            }
            return res;
        }

        // Devuelve una planta por su ID o null si no existe
        public Planta getPlantaById(int idPlanta)
        {
            Planta plantaRes = new Planta();

            foreach (Planta planta in _listadoPlantas)
            {
                if (planta.id == idPlanta) { plantaRes = planta; }
            }
            return plantaRes;
        }

        // Devuelve todas las plantas de una categoría
        public List<Planta> getPlantasByCategoria(int idCategoria)
        {
            List<Planta> plantasByCategoria = new List<Planta>();

            foreach (Planta planta in _listadoPlantas) 
            {
                if (planta.idCategoria == idCategoria) { plantasByCategoria.Add(planta); }
            }
            return plantasByCategoria;
        }
        #endregion
    }
}
