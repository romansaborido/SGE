using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PlantaDTO
    {
        #region propiedades
        public Planta planta { get; }
        public string nombreCategoria { get; }
        #endregion

        #region constructores
        public PlantaDTO(Planta planta, string nombreCategoria) {
            this.planta = planta;
            this.nombreCategoria = nombreCategoria;
        }
        #endregion
    }
}
