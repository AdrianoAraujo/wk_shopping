using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WK_Shopping.ProdutoAPI.Data.ValueObjects;
using WK_Shopping.ProdutoAPI.Repository;

namespace WK_Shopping.ProdutoAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepository _repository;

        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoVO>>> FindAll()
        {
            var produtos = await _repository.FindAll();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoVO>> FindById(long id)
        {
            var produto = await _repository.FindById(id);
            if (produto == null) return NotFound();
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoVO>> Create([FromBody] ProdutoVO vo)
        {
            if (vo == null) return BadRequest();
            var produto = await _repository.Create(vo);
            return Ok(produto);
        }

        [HttpPut]
        public async Task<ActionResult<ProdutoVO>> Update([FromBody] ProdutoVO vo)
        {
            if (vo == null) return BadRequest();
            var produto = await _repository.Update(vo);
            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
