using System.Collections.Generic;

namespace ProjetoPedidos.Models
{
    public interface IPedidoRepository
    {
        IEnumerable<Pedido> Pedidos { get; }

        Pedido GetPedidoById(int PedidoId);

    }
}
