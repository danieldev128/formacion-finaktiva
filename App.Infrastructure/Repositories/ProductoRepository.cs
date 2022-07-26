
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

    public interface IProductoRepository : IBaseRepository<Producto>
    {
        Producto AgregarProducto(Producto producto);
        List<Producto> ObtenerProductos();
        List<vw_productos> ObtenerVwProductos();
        vw_productos editarProducto(int idProducto);
    }
    public class ProductoRepository : BaseRepository<Producto>, IProductoRepository
    {
        private DataContext _ctx;
        public ProductoRepository(DataContext database) : base(database)
        {
            _ctx = database;
        }

        public List<Producto> ObtenerProductos() {

            return _table.ToList();

        }

        public Producto AgregarProducto(Producto producto) {

            var productoR = _table.Add(producto);
            _database.SaveChanges();
            return productoR.Entity;


        }

        public List<vw_productos> ObtenerVwProductos(){

            return _ctx.VwProdcutos.ToList();
        }

        public vw_productos editarProducto(int idProducto) {

            var productoR = _ctx.VwProdcutos.Find(idProducto);
            return productoR;
        
        }


    }
}
