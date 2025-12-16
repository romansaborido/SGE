using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        #region atributos
        private List<Categoria> _listadoCategorias;
        #endregion

        #region constructores
        public CategoriaRepository() {
            _listadoCategorias = new List<Categoria>()
            {
                new Categoria { id = 1, nombre = "Plantas de Interior" },
                new Categoria { id = 2, nombre = "Plantas de Exterior" },
                new Categoria { id = 3, nombre = "Suculentas" }
            };
        }
        #endregion

        #region metodos
        // Devuelve el listado completo de categorias
        public List<Categoria> getCategorias()
        {
            return _listadoCategorias;    
        }

        // Devuelve el nombre de la categoria o cadena vacia si no existe
        public string getNombreCategoria(int idCategoria)
        {
            string nombreCategoria = "";

            foreach (Categoria categoria in _listadoCategorias) {
                if (categoria.id == idCategoria) { nombreCategoria = categoria.nombre; }
            }
            return nombreCategoria;
        }
        #endregion
    }
}
