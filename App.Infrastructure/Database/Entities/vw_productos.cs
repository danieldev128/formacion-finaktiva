using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Database.Entities
{   
    [Table("vw_productos")]
    public class vw_productos: Producto
    {

        public int Cantidad { get; set; }
    }
}
