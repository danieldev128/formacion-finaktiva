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
    public interface IDetalleRepository :IBaseRepository<Detalle>
    {
        public List<Detalle> ObtenerDetalle();
        public Detalle AgregarDetalle(Detalle detalle);
    }
    public class DetalleRepository : BaseRepository<Detalle>,IDetalleRepository
    {

        public DetalleRepository(DataContext database) : base(database)
        {


        }

        public List<Detalle> ObtenerDetalle() 
        {

            return _table.ToList();


        }

        public Detalle AgregarDetalle(Detalle detalle) 
        {
            var detalleR = _table.Add(detalle);
            _database.SaveChanges();
            return detalleR.Entity;
        
        }
      
    }

   
}
