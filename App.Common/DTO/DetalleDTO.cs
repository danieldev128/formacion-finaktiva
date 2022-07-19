using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.DTO
{
    public class DetalleDTO
    {
       
        [Required]
        public int CantidadProducto { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public int IdFactura { get; set; }

    }
}
