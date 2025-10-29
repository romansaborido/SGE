using Domain.Entities;
using Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ListadoPersonasEmpty : IListadoPersonasRepository
    {
        #region atributos
        private List<Persona> _listadoPersonasEmpty;
        #endregion

        #region constructores
        public ListadoPersonasEmpty() 
        {
            _listadoPersonasEmpty = new List<Persona>();
        }
        #endregion

        #region propiedades
        public List<Persona> getListadoPersonas() {
            return _listadoPersonasEmpty;
        }
        #endregion
    }
}