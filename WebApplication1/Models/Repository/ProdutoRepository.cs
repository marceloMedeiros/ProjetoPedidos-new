using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoPedidos.Models
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProdutoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Produto> Produtos
        {
            get
            {
                return _appDbContext.Produtos;
            }
        }

        public Produto GetProdutoById(int produtoId)
        {
            return _appDbContext.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
        }
    }
}
