using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs
{
    public class IdPersonaDepartamentoDTO
    {
        #region propiedades
        public int idPersona { get; }
        public int idDepartamento { get; }
        #endregion

        #region constructores
        public IdPersonaDepartamentoDTO(int idPersona, int idDepartamento) { 
            this.idPersona = idPersona;
            this.idDepartamento = idDepartamento;
        }
        #endregion
    }
}
