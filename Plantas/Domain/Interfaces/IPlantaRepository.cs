using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPlantaRepository
    {
        List<Planta> getPlantasByCategoria(int idCategoria);
        Planta getPlantaById(int idPlanta);
        int cambiarPrecio(int idPlanta, double nuevoPrecio);
    }
}
