using AutoMapper;
using WK_Shopping.ProdutoAPI.Data.ValueObjects;
using WK_Shopping.ProdutoAPI.Model;
using WK_Shopping.ProdutoAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace WK_Shopping.ProdutoAPI.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public ProdutoRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoVO>> FindAll()
        {
            List<Produto> produtos = await _context.Produtos.ToListAsync();
            return _mapper.Map<List<ProdutoVO>>(produtos);
        }

        public async Task<ProdutoVO> FindById(long id)
        {
            Produto produto =
                await _context.Produtos.Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return _mapper.Map<ProdutoVO>(produto);
        }

        public async Task<ProdutoVO> Create(ProdutoVO vo)
        {
            Produto produto = _mapper.Map<Produto>(vo);
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProdutoVO>(produto);
        }

        public async Task<ProdutoVO> Update(ProdutoVO vo)
        {
            Produto produto = _mapper.Map<Produto>(vo);
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProdutoVO>(produto);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Produto produto =
                await _context.Produtos.Where(x => x.Id == id)
                    .FirstOrDefaultAsync();
                if (produto == null) return false;
                _context.Produtos.Remove(produto);
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
