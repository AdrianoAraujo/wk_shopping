using WK_Shopping.Web.Models;

namespace WK_Shopping.Web.Services.IServices
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaModel>> FindAllCategorias();
        Task<CategoriaModel> FindCategoriaById(long id);
        Task<CategoriaModel> CreateCategoria(CategoriaModel model);
        Task<CategoriaModel> UpdateCategoria(CategoriaModel model);
        Task<bool> DeleteCategoriaById(long id);
    }
}
