using App.Common.DTO;
using App.Infrastructure.Base;
using App.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{

    public interface IProductoRepository : IBaseRepository<Producto>
    {
        Producto AgregarProducto(Producto producto);
        List<Producto> ObtenerProductos();

    }
    public class ProductoRepository : BaseRepository<Producto>, IProductoRepository
    {
        public ProductoRepository(DataContext database) : base(database)
        {

        }

        public List<Producto> ObtenerProductos() {

            return _table.ToList();
        
        }

        public Producto AgregarProducto(Producto producto) {

            var productoR = _table.Add(producto);
            _database.SaveChanges();
            return productoR.Entity;
            
        
        }


    }
}
