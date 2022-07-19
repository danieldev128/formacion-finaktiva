using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Common.DTO;
using App.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Database
{
    public class DataContext: DbContext
    {

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Detalle> Detalle { get; set; }
        public DbSet<Empleado> Empleado { get; set;}
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Factura> Factura { get; set; }
        //public DbSet<LogsGeneral> LogsGeneral { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
