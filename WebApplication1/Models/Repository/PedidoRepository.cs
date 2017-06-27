using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoPedidos.Models
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;

        public PedidoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pedido> Pedidos
        {
            get
            {
                return _appDbContext.Pedidos.Include(c => c.ItemPedido);
            }
        }

        public Pedido GetPedidoById(int pedidoid)
        {
            return _appDbContext.Pedidos.FirstOrDefault(p => p.PedidoId == pedidoid);
        }


       
    }
}
