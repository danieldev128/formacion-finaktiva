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
        public int CantidadProducto { get; set; }
        public decimal Precio { get; set; }

        public int IdProducto { get; set; }

        public int IdFactura { get; set; }

    }
}
