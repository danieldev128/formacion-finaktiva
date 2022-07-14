using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.DTO
{
    public class EmpleadoDTO
    {
        [Key]
        public int idEmpleado { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Direccion { get; set; }

        public string correo { get; set; }

        public int edad { get; set; }

        public string cedula { get; set; }

        public string cargo { get; set; }

        public string contrasena { get; set; }
    }
}
