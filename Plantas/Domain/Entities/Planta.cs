using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Planta
    {
        #region atributos
        private int _id;
		private string _nombre;
        private string _descripcion;
        private double _precio;
        private int _idCategoria;
        #endregion

        #region propiedades
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int idCategoria { get; set; }
        #endregion

        #region constructores
        public Planta() { }
        public Planta(int id, string nombre, string descripcion, double precio, int idCategoria) {
            _id = id;
            _nombre = nombre;
            _descripcion = descripcion;
            _precio = precio;
            _idCategoria = idCategoria;
        }
        #endregion
    }
}
