using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPedidos.Models
{
    public class DbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();//TODO: check music store implementation

           if (!context.Produtos.Any())
            {
                context.AddRange
                (
                    new Produto {  Descricao = "Yamaha Xj6 N", Valor = 33.190M },
                    new Produto {  Descricao = "Yamaha XT 660", Valor = 30.620M },
                    new Produto {  Descricao = "Yamaha YS 250 Fazer", Valor = 14.258M },
                    new Produto {  Descricao = "Yamaha Xtz 250 Lander", Valor = 15.627M },
                    new Produto {  Descricao = "Yamaha MT-01 670", Valor = 47.190M },
                    new Produto {  Descricao = "Honda CBR 600 ", Valor = 37.650M },
                    new Produto {  Descricao = "Honda CB 500", Valor = 30.172M }
                );
            }

            context.SaveChanges();

            if (!context.Clientes.Any())
            {
                context.AddRange
                (
                    new Cliente { NomeCliente = "João da Silva", CPF = "1621785556" },
                    new Cliente { NomeCliente = "Antônio Pereira", CPF = "12443048756" },
                    new Cliente { NomeCliente = "Ricardo Prates", CPF = "73665859638" },
                    new Cliente { NomeCliente = "Jaqueline de Oliveira", CPF = "78156724933" },
                    new Cliente { NomeCliente = "Felipe Jesus da Cotas", CPF = "96332608684" },
                    new Cliente { NomeCliente = "Edson Teixeira Aquino", CPF = "15519634343" },
                    new Cliente { NomeCliente = "Débora Menezes", CPF = "96107488308" }
                );
            }

            context.SaveChanges();


        }

       
    }
}
