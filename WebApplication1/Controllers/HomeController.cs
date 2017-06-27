using ProjetoPedidos.Models;
//using ProjetoPedidos.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoPedidos.Controllers
{
    public class HomeController: Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public HomeController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public ViewResult Index()
        {
            //var homeViewModel = new HomeViewModel
            //{
            //    PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            //};

            return View();
        }
    }
}
