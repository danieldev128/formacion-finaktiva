using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.DTO
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }

        public decimal PrecioProducto { get; set; }
        public string DescripcionProducto { get; set; }

        public bool Disponible { get; set; } 

    }
}
