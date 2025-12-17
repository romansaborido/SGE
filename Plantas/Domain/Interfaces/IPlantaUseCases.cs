using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTOs;

namespace Domain.Interfaces
{
    public interface IPlantaUseCases
    {
        PlantasCategoriasDTO getPlantasCategorias(int? idCategoria);
        PlantaDTO getPlantaById(int idPlanta);
        int cambiarPrecio(int idPlanta, decimal nuevoPrecio);
    }
}
