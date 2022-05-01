using Microsoft.AspNetCore.Mvc;
using WK_Shopping.Web.Models;
using WK_Shopping.Web.Services.IServices;

namespace WK_Shopping.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService ?? throw new 
                ArgumentNullException(nameof(produtoService));
        }

        public async Task<IActionResult> ProdutoIndex()
        {
            var produtos = await _produtoService.FindAllProdutos();
            return View(produtos);
        }

        public async Task<IActionResult> ProdutoCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProdutoCreate(ProdutoModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _produtoService.CreateProduto(model);
                if (response != null) return RedirectToAction(
                     nameof(ProdutoIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> ProdutoUpdate(int id)
        {
            var model = await _produtoService.FindProdutoById(id);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ProdutoUpdate(ProdutoModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _produtoService.UpdateProduto(model);
                if (response != null) return RedirectToAction(
                     nameof(ProdutoIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> ProdutoDelete(int id)
        {
            var model = await _produtoService.FindProdutoById(id);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ProdutoDelete(ProdutoModel model)
        {
            var response = await _produtoService.DeleteProdutoById(model.Id);
            if (response) return RedirectToAction(
                    nameof(ProdutoIndex));
            return View(model);
        }
    }
}
