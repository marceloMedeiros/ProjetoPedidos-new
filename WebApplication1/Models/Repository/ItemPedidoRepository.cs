using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoPedidos.Models
{
    public class ItemPedidoRepository : IItemPedidoRepository
    {
        private readonly AppDbContext _appDbContext;

        public ItemPedidoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ItemPedido> ItensPedido
        {
            get
            {
                return _appDbContext.ItensPedido;
            }
        }

        public ItemPedido GetItemsPedidoById(int pedidoid)
        {
            return _appDbContext.ItensPedido.FirstOrDefault(p => p.PedidoId == pedidoid);
        }

        public ItemPedido GetItemsPedidoByItemId(int itempedidoid)
        {
            return _appDbContext.ItensPedido.FirstOrDefault(p => p.ItemPedidoId == itempedidoid);
        }
    }
}
