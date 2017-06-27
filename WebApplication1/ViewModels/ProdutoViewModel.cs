using System.Collections.Generic;
using ProjetoPedidos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjetoPedidos.ViewModels
{
    public class ProdutoViewModel
    {
            public IEnumerable<Produto> Produtos { get; set; }
            public List<SelectListItem> ProdutosList { get; set; }

            public string DescricaoProduto { get; set; }

    }


}


