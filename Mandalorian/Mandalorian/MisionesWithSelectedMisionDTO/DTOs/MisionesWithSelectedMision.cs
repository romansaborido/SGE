using Domain.Entities;
using DTO.Interfaces;

namespace DTO.DTOs
{
    public class MisionesWithSelectedMision : IMisionesWithSelectedMision
    {
        #region atributos
        private List<Mision> _listadoMisiones;
        private Mision _misionSeleccionada;
        #endregion

        #region constructores
        public MisionesWithSelectedMision(List<Mision> listadoMisiones, Mision misionSeleccionada) 
        {
            _listadoMisiones = listadoMisiones;
            _misionSeleccionada = misionSeleccionada;
        }
        public MisionesWithSelectedMision() { }
        #endregion


    }
}
