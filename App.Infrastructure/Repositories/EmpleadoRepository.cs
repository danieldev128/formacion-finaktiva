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

    public interface IEmpleadoRepository : IBaseRepository<Empleado>
    {
        public List<Empleado> ObtenerEmpleado();
        public Empleado AgregarEmpleado(Empleado empleado);
    }
    public class EmpleadoRepository : BaseRepository<Empleado>,IEmpleadoRepository
    {

        public EmpleadoRepository(DataContext database) : base(database) 
        {
        }

        public List<Empleado> ObtenerEmpleado() {

            return _table.ToList();
        
        }

        public Empleado AgregarEmpleado(Empleado empleado)
        {

            var empleadoR = _table.Add(empleado);
            _database.SaveChanges();
            return empleadoR.Entity;
        }


    }

  
}
