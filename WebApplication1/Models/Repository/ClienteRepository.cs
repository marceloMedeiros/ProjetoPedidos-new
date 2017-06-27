using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoPedidos.Models
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _appDbContext;

        public ClienteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Cliente> Clientes
        {
            get
            {
                return _appDbContext.Clientes;
            }
        }

        public Cliente GetClienteById(int clienteid)
        {
            return _appDbContext.Clientes.FirstOrDefault(p => p.ClienteId == clienteid);
        }
    }
}
