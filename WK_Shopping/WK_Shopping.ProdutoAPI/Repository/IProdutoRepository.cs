using WK_Shopping.ProdutoAPI.Data.ValueObjects;

namespace WK_Shopping.ProdutoAPI.Repository
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<ProdutoVO>> FindAll();
        Task<ProdutoVO> FindById(long id);
        Task<ProdutoVO> Create(ProdutoVO vo);
        Task<ProdutoVO> Update(ProdutoVO vo);
        Task<bool> Delete(long id);
    }
}
