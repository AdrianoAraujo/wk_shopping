using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WK_Shopping.CategoriaAPI.Data.ValueObjects;
using WK_Shopping.CategoriaAPI.Repository;

namespace WK_Shopping.CategoriaAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private ICategoriaRepository _repository;

        public CategoriaController(ICategoriaRepository repository)
        {
            _repository = repository ?? throw new 
                ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaVO>>> FindAll()
        {
            var categorias = await _repository.FindAll();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaVO>> FindById(long id)
        {
            var categoria = await _repository.FindById(id);
            if (categoria == null) return NotFound();
            return Ok(categoria);
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaVO>> Create([FromBody] CategoriaVO vo)
        {
            if (vo == null) return BadRequest();
            var categoria = await _repository.Create(vo);
            return Ok(categoria);
        }

        [HttpPut]
        public async Task<ActionResult<CategoriaVO>> Update([FromBody] CategoriaVO vo)
        {
            if (vo == null) return BadRequest();
            var categoria = await _repository.Update(vo);
            return Ok(categoria);
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
