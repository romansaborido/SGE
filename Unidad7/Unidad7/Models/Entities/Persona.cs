namespace Unidad7.Models.Entities
{
    public class Persona
    {
        #region atributos privados
        private int _id;
        private string _name;
        #endregion

        #region constructores
        public Persona() { }
        public Persona(int id, string name) { 
            _id = id;
            _name = name;
        }
        #endregion

        #region getters y setters
        public int id { 
            get { return _id; } 
        }
        public string name { 
            get { return _name; }
            set { _name = value; }
        }
        #endregion
    }
}
