using WK_Shopping.Web.Models;

namespace WK_Shopping.Web.Services.IServices
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoModel>> FindAllProdutos();
        Task<ProdutoModel> FindProdutoById(long id);
        Task<ProdutoModel> CreateProduto(ProdutoModel model);
        Task<ProdutoModel> UpdateProduto(ProdutoModel model);
        Task<bool> DeleteProdutoById(long id);
    }
}
