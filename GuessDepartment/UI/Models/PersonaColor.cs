using Domain.DTOs;

namespace UI.Models
{
    public class PersonaColor
    {
        #region propiedades
        public PersonaDepartamentosDTO persona { get; }
        public string color { get; }
        #endregion

        #region constructores
        public PersonaColor(PersonaDepartamentosDTO persona, string color) 
        {
            this.persona = persona;
            this.color = color;
        }
        #endregion
    }
}
