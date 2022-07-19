using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Database.Entities
{
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }
        [Required]
        public decimal Iva { get; set; }
        [Required]
        public int IdEstadoFactura { get; set; }
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public int IdEmpleado { get; set; }
        [Required]
        public DateTime FechaFactura { get; set; }
    }
}
