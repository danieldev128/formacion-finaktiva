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
    public interface IClienteRepository : IBaseRepository<Cliente> {

        public List<Cliente> ObtenerClientes();
        public Cliente AgregarCliente(Cliente cliente);
    
    }
    public class ClienteRepository : BaseRepository<Cliente>,IClienteRepository  
    {

        public ClienteRepository(DataContext database) : base(database)
        {


        }
        public List<Cliente> ObtenerClientes()
        {
            return _table.ToList();
        }

        public Cliente AgregarCliente(Cliente cliente)
        {

            var clienteR = _table.Add(cliente);
            _database.SaveChanges();
            return clienteR.Entity;
           



        }
    }

}
