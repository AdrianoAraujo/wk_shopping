using WK_Shopping.CategoriaAPI.Data.ValueObjects;

namespace WK_Shopping.CategoriaAPI.Repository
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<CategoriaVO>> FindAll();
        Task<CategoriaVO> FindById(long id);
        Task<CategoriaVO> Create(CategoriaVO vo);
        Task<CategoriaVO> Update(CategoriaVO vo);
        Task<bool> Delete(long id);
    }
}
