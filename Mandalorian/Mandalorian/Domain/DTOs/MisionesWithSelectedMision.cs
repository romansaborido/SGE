using Domain.Entities;

namespace DTO.DTOs
{
    public class MisionesWithSelectedMision
    {
        #region atributos
        private List<Mision> _listadoMisiones;
        private Mision _misionSeleccionada;
        #endregion

        #region constructores
        public MisionesWithSelectedMision(List<Mision> listadoMisiones) 
        {
            _listadoMisiones = listadoMisiones;
        }
        public MisionesWithSelectedMision(List<Mision> listadoMisiones, Mision misionSeleccionada) 
        {
            _listadoMisiones = listadoMisiones;
            _misionSeleccionada = misionSeleccionada;
        }
        public MisionesWithSelectedMision() { }
        #endregion

        #region propiedades
        public List<Mision> listadoMisiones 
        {
            get { return _listadoMisiones; }
        }
        public Mision misionSeleccionada 
        {
            get { return _misionSeleccionada; }
        }
        #endregion

    }
}
