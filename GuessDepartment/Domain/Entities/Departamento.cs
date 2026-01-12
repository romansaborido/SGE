using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Departamento
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
        public Departamento() { }
        public Departamento(int id, string nombre) {
            _id = id;
            _nombre = nombre;
        }
        #endregion
    }
}
