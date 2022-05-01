using Microsoft.AspNetCore.Mvc;
using WK_Shopping.Web.Models;
using WK_Shopping.Web.Services.IServices;

namespace WK_Shopping.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService ?? throw new 
                ArgumentNullException(nameof(categoriaService));
        }

        public async Task<IActionResult> CategoriaIndex()
        {
            var produtos = await _categoriaService.FindAllCategorias();
            return View(produtos);
        }

        public async Task<IActionResult> CategoriaCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CategoriaCreate(CategoriaModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _categoriaService.CreateCategoria(model);
                if (response != null) return RedirectToAction(
                     nameof(CategoriaIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> CategoriaUpdate(int id)
        {
            var model = await _categoriaService.FindCategoriaById(id);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CategoriaUpdate(CategoriaModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _categoriaService.UpdateCategoria(model);
                if (response != null) return RedirectToAction(
                     nameof(CategoriaIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> CategoriaDelete(int id)
        {
            var model = await _categoriaService.FindCategoriaById(id);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CategoriaDelete(CategoriaModel model)
        {
            var response = await _categoriaService.DeleteCategoriaById(model.Id);
            if (response) return RedirectToAction(
                    nameof(CategoriaIndex));
            return View(model);
        }
    }
}
