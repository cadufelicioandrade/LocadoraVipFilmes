using AutoMapper;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    public class ProdutoraController : ControllerBase
    {
        private readonly IProdutoraRepository _produtoraRepository;
        private readonly IMapper _mapper;

        public ProdutoraController(IProdutoraRepository produtoraRepository, IMapper mapper)
        {
            _produtoraRepository = produtoraRepository ?? throw new ArgumentNullException(nameof(produtoraRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                var produtoras = await _produtoraRepository.GetAll();

                if (produtoras.Count() > 0)
                    return Ok(produtoras);

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var produtora = await _produtoraRepository.GetById(id);

                if (produtora != null)
                    return Ok(produtora);

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Produtora produtora)
        {
            if (ModelState.IsValid)
            {
                _produtoraRepository.Add(produtora);
                return CreatedAtAction(nameof(GetById), new { Id = produtora.Id}, produtora);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Produtora produtora)
        {
            if (ModelState.IsValid)
            {
                _produtoraRepository.Update(produtora);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = await _produtoraRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
