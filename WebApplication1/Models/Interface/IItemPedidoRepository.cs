using System.Collections.Generic;

namespace ProjetoPedidos.Models
{
    public interface IItemPedidoRepository
    {
        IEnumerable<ItemPedido> ItensPedido { get; }

        ItemPedido GetItemsPedidoById(int PedidoId);

        ItemPedido GetItemsPedidoByItemId(int ItensPedidoId);
        
    }
}
