using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Database.Entities
{
    public  class Detalle
    {
        [Key]
        public int IdDetalle { get; set; }

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
