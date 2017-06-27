using System.Collections.Generic;

namespace ProjetoPedidos.Models
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }

        Produto GetProdutoById(int ProdutoId);
        
    }
}
