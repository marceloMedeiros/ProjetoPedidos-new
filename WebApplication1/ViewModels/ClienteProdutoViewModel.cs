using System.Collections.Generic;
using ProjetoPedidos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace ProjetoPedidos.ViewModels
{
    public class ClienteProdutoViewModel
    {
            public IEnumerable<Cliente> Clientes { get; set; }
            public List<SelectListItem> ClientesList { get; set; }

            public string NomeCliente { get; set; }

            public IEnumerable<Produto> Produtos { get; set; }
            public List<SelectListItem> ProdutosList { get; set; }

            public string DescricaoProduto { get; set; }

            [Required(ErrorMessage = "Informe a data de entrega.")]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
            [DataType(DataType.Date, ErrorMessage = "Valor informado não é uma data válida.")]
            [DisplayName("Data de Entrega")]
            public DateTime DataEntrega { get; set; }

    }


}


