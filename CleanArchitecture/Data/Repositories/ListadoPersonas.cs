using Domain.Entities;
using Domain.Interfaces.IRepositories;

namespace Data.Repositories
{
    public class ListadoPersonas : IListadoPersonasRepository
    {
        #region atributos
        private List<Persona> _listadoPersonas;
        #endregion

        #region constructores
        public ListadoPersonas()
        {
            _listadoPersonas = new List<Persona>
            {
                new Persona(1, "Ana", 25),
                new Persona(2, "Luis", 30),
                new Persona(3, "María", 22),
                new Persona(4, "Carlos", 28),
                new Persona(5, "Lucía", 27),
                new Persona(6, "Jorge", 35),
                new Persona(7, "Sofía", 24),
                new Persona(8, "Miguel", 32),
                new Persona(9, "Laura", 29),
                new Persona(10, "Pedro", 31)
            };
        }
        #endregion

        #region propiedades
        public List<Persona> getListadoPersonas()
        {
            return _listadoPersonas;
        }
        #endregion
    }
}