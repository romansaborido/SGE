using Domain.Entities;
using DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IListadoMisionesUseCases
    {
        List<Mision> getMisiones();
        Mision getMisionById(int id);
        IMisionesWithSelectedMision getMisionesWithSelectedMision(int idSeleccionado);
    }
}
