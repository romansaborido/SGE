using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Persona
    {
        #region atributos
        private int _id;
        private string _nombre;
        private string _apellidos;
        private string _telefono;
        private string _direccion;
        private string _foto;
        #endregion

        #region propiedades
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string foto { get; set; }
        public DateOnly fechaNacimiento { get; set; }
        public int idDepartamento { get; set; }
        #endregion

        #region constructores
        public Persona() { }
        public Persona(int id, string nombre, string apellidos, string telefono, string direccion, string foto, DateOnly fechaNacimiento, int idDepartamento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.foto = foto;
            this.fechaNacimiento = fechaNacimiento;
            this.idDepartamento = idDepartamento;
        }
        #endregion
    }
}
