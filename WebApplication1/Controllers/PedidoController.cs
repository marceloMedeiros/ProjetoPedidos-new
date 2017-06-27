using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoPedidos.Models;
using ProjetoPedidos.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetoPedidos.Controllers
{
    public class PedidoController : Controller
    {

        private readonly IClienteRepository _clienteRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IItemPedidoRepository _itemPedidoRepository;

        public PedidoController(IClienteRepository clienteRepository, 
                                IProdutoRepository produtoRepository,
                                IPedidoRepository pedidoRepository,
                                IItemPedidoRepository itemPedidoRepository)

        {
            _clienteRepository = clienteRepository;
            _produtoRepository = produtoRepository;
            _pedidoRepository = pedidoRepository;
            _itemPedidoRepository = itemPedidoRepository;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Titulo = "Pedido de Vendas - Inclusão";

            var vm = new ClienteProdutoViewModel();

            IEnumerable<Cliente> clientes;
            clientes = _clienteRepository.Clientes.OrderBy(p => p.ClienteId);
            vm.Clientes = clientes;

            IEnumerable<Produto> produtos;
            produtos = _produtoRepository.Produtos.OrderBy(p => p.ProdutoId);
            vm.Produtos = produtos;

            vm.DataEntrega = DateTime.Now.Date;

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Incluir(ClienteProdutoViewModel model)
        {
           
            return View(model);
        }

        public IActionResult Consultar()
        {
            ViewBag.Titulo = "Pedido de Vendas - Consultar";

            return View();
        }


    }
}
