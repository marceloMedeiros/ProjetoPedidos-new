using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPedidos.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DataEntrega { get; set; }
        public long NumeroPedido { get; set; }
        public long NomeCliente { get; set; }
        public decimal ValorTotal { get; set; }
        public List<ItemPedido> ItemPedido { get; set; }

    }
}
