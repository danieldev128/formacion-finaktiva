using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Database.Entities
{
    public class Inventario
    {   
        [Key]
        public int IdInventario { get; set; }
        public int CantidadProducto { get; set; }
        public int IdProducto { get; set; }
    }
}
