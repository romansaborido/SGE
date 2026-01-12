using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IPersonaUseCases
    {
        List<PersonaDepartamentosDTO> getPersonas();
        int getAciertos(List<IdPersonaDepartamentoDTO> resForm);
    }
}
