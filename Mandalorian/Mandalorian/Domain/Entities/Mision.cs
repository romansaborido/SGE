using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Mision
    {
        #region atributos
        private int _id;
        private string _nombre;
        private string _descripcion;
        private decimal _recompensa;
        #endregion

        #region constructores
        public Mision() { }
        public Mision(int id, string nombre, string descripcion, decimal recompensa)
        {
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
            _recompensa = recompensa;
        }
        #endregion

        #region propiedades
        public int id {
            get { return _id; }
        }
        public string nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string descripcion {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public decimal recompensa {
            get { return _recompensa; }
            set { _recompensa = value; }
        }
        #endregion
    }
}
