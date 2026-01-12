using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IPersonaRepository
    {
        List<Persona> getPersonas();
        List<IdPersonaDepartamentoDTO> getIds();
    }
}
