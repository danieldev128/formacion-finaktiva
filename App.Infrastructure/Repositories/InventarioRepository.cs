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
    public interface IinventarioRepository
    {
        public List<Inventario> ObtenerInventario();
        public Inventario AgregarInventario(Inventario inventario);
    }
    public class InventarioRepository : BaseRepository<Inventario>, IinventarioRepository
    {
        public InventarioRepository(DataContext database) : base(database) { }

        public List<Inventario> ObtenerInventario() {
            return _table.ToList();
        
        }

        public Inventario AgregarInventario(Inventario inventario) 
        {
            var inventarioR = _table.Add(inventario);
            _database.SaveChanges();
            return inventarioR.Entity;
        }

        

    }

   
}
