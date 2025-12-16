using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PlantasCategoriasDTO
    {
        #region propiedades
        public List<Planta> plantasByCategoria { get; }
        public List<Categoria> categorias { get; }
        #endregion

        #region constructores
        public PlantasCategoriasDTO(List<Categoria> categorias) {
            this.categorias = categorias;
        }
        public PlantasCategoriasDTO(List<Planta> plantas, List<Categoria> categorias)
        {
            this.plantasByCategoria = plantas;
            this.categorias = categorias;
        }
        #endregion
    }
}
