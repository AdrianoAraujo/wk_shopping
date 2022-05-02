using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WK_Shopping.Web.Models;
using WK_Shopping.Web.Services.IServices;

namespace WK_Shopping.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IProdutoService _produtoService;

        public HomeController(ILogger<HomeController> logger, IProdutoService produtoService)
        {
            _logger = logger;
            _produtoService = produtoService;
        }

        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoService.FindAllProdutos();
            return View(produtos);
        }

        public async Task<IActionResult> Detalhes(int id)
        {
            var model = await _produtoService.FindProdutoById(id);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}