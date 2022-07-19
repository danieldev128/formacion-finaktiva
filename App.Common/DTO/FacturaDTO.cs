using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.DTO
{
    public class FacturaDTO
    {   
    
       
        public int IdEstadoFactura { get; set; }

        public int IdCliente { get; set; }

        public int IdEmpleado { get; set; }

        public DateTime FechaFactura { get; set; }

    }
}
