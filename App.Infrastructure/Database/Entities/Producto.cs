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

        [Required]
        public string NombreProducto { get; set; }
        [Required]
        public decimal PrecioProducto { get; set; }
        [Required]
        public string DescripcionProducto { get; set; }
        [Required]
        public bool Disponible { get; set; } 

    }
}
