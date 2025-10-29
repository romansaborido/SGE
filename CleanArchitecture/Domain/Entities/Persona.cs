using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persona
    {
        #region atributos
        private int _id;
        private string _nombre;
        private int _edad;
        #endregion

        #region constructores
        public Persona() { }

        public Persona(int id, string nombre, int edad)
        {
            _id = id;
            _nombre = nombre;
            _edad = edad;
        }
        #endregion

        #region propiedades
        public int id 
        {
            get { return _id; }
        }
        public string nombre 
        { 
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int edad 
        {
            get { return _edad; }
            set { _edad = value; }
        }
        #endregion
    }
}
