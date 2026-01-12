using Domain.DTOs;
using UI.Models;

namespace UI.Mappers
{
    public class PersonaDTOtoPersonaColor : IPersonaDTOtoPersonaColor
    {
        public PersonaColor map(PersonaDepartamentosDTO perDptos)
        {
            PersonaDepartamentosDTO perDto = new PersonaDepartamentosDTO(perDptos.id, perDptos.nombre, perDptos.apellidos, perDptos.idDepartamento, perDptos.departamentos);
            string color;

            if (perDptos.idDepartamento == 1)
            {
                color = "green";
            }
            else if (perDptos.idDepartamento == 2)
            {
                color = "blue";
            }
            else if (perDptos.idDepartamento == 3)
            {
                color = "yellow";
            }
            else
            {
                color = "red";
            }

            return new PersonaColor(perDto, color);
        }
    }
}
