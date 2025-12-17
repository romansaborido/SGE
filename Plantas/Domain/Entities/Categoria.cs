using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Categoria
    {
        #region atributos
        private int _id;
        private string _nombre;
        #endregion

        #region propiedades
        public int id { get; set; }
        public string nombre { get; set; }
        #endregion

        #region constructores
        public Categoria() { }
        public Categoria(int id, string nombre) { }
        #endregion
    }
}
