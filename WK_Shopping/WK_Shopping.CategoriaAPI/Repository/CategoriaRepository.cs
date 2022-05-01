using AutoMapper;
using WK_Shopping.CategoriaAPI.Data.ValueObjects;
using WK_Shopping.CategoriaAPI.Model;
using WK_Shopping.CategoriaAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace WK_Shopping.CategoriaAPI.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public CategoriaRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoriaVO>> FindAll()
        {
            List<Categoria> categorias = await _context.Categorias.ToListAsync();
            return _mapper.Map<List<CategoriaVO>>(categorias);
        }

        public async Task<CategoriaVO> FindById(long id)
        {
            Categoria categoria =
                await _context.Categorias.Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return _mapper.Map<CategoriaVO>(categoria);
        }

        public async Task<CategoriaVO> Create(CategoriaVO vo)
        {
            Categoria categoria = _mapper.Map<Categoria>(vo);
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
            return _mapper.Map<CategoriaVO>(categoria);
        }

        public async Task<CategoriaVO> Update(CategoriaVO vo)
        {
            Categoria categoria = _mapper.Map<Categoria>(vo);
            _context.Categorias.Update(categoria);
            await _context.SaveChangesAsync();
            return _mapper.Map<CategoriaVO>(categoria);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Categoria categoria =
                await _context.Categorias.Where(x => x.Id == id)
                    .FirstOrDefaultAsync();
                if (categoria == null) return false;
                _context.Categorias.Remove(categoria);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
