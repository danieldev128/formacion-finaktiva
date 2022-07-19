using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Database.Entities
{
    public class Empleado
    {
        [Key]
        public int idEmpleado { get; set; }
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string Direccion { get; set; }
        [Required]
        public string correo { get; set; }

        [Required]
        public int edad { get; set; }
        [Required]
        public string cedula { get; set; }
        [Required]
        public string cargo { get; set; }

        [Required]
        public string contrasena { get; set; }

    }
}
