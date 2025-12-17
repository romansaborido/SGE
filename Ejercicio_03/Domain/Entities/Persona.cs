using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private string _apellidos;
        private string _telefono;
        private string _direccion;
        private string _foto;
        private DateOnly _fechaNacimiento;
        private int _idDepartamento;
        #endregion

        #region constructores
        public Persona() { }
        public Persona(int id, string nombre, string apellidos, string telefono, string direccion, string foto, DateOnly fechaNacimiento, int idDepartamento)
        {
            _id = id;
            _nombre = nombre;
            _apellidos = apellidos;
            _telefono = telefono;
            _direccion = direccion;
            _foto = foto;
            _fechaNacimiento = fechaNacimiento;
            _idDepartamento = idDepartamento;
        }
        #endregion

        #region propiedades
        [Required(ErrorMessage = "Campo obligatorio")]
        public int id
        {
            get { return _id; }
            set { _id = value; } // Se lo he puesto porque cuando estoy obteniendo los datos de la BD tengo que actualizarlo
        }
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres")]
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(60, ErrorMessage = "Máximo 60 caracteres")]
        public string apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Debe tener exactamente 9 números")]
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public string foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
        [DataType(DataType.Date)]
        public DateOnly fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public int idDepartamento
        {
            get { return _idDepartamento; }
            set { _idDepartamento = value; }
        }
        #endregion
    }
}
