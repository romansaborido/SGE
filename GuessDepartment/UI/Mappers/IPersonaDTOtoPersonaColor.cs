using Domain.DTOs;
using UI.Models;

namespace UI.Mappers
{
    public interface IPersonaDTOtoPersonaColor
    {
        PersonaColor map(PersonaDepartamentosDTO perDptos);
    }
}
