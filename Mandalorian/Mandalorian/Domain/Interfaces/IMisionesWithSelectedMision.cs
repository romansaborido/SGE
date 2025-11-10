using Domain.Entities;
using DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Interfaces
{
    public interface IMisionesWithSelectedMision
    {
        List<Mision> listadoMisiones { get; }
        Mision misionSeleccionada { get; }
    }
}
