using App.Infrastructure.Base;
using App.Infrastructure.Database;
using App.Infrastructure.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
    public  interface IFacturaRepository : IBaseRepository<Factura>
    {
        public Factura AgregarFactura(Factura factura);
        public List<Factura> ObtenerFactura();

    }
    public class FacturaRepository : BaseRepository<Factura>,IFacturaRepository
    {


        public FacturaRepository(DataContext database) : base(database)
        {

        }


        public List<Factura> ObtenerFactura() 
        {

            return _table.ToList();
        }


        public Factura AgregarFactura(Factura factura) 
        {
            var facturaR = _table.Add(factura);
            _database.SaveChanges();
            return facturaR.Entity;
        }
    }
}
