using System.Collections.Generic;

namespace ProjetoPedidos.Models
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> Clientes { get; }

        Cliente GetClienteById(int ClienteId);

    }
}
