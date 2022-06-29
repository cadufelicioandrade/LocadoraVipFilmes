using AutoMapper;
using LocadoraVipFilmes.API.DTOs.ProdutoraDTO;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "admin, funcionario")]
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
        public IActionResult GetAll()
        {
            if (ModelState.IsValid)
            {
                var produtoras = _produtoraRepository.GetAll();

                if (produtoras.Count() > 0)
                    return Ok(_mapper.Map<IEnumerable<ReadProdutoraDTO>>(produtoras));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var produtora = _produtoraRepository.GetById(id);

                if (produtora != null)
                    return Ok(_mapper.Map<ReadProdutoraDTO>(produtora));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateProdutoraDTO dto)
        {
            if (ModelState.IsValid)
            {
                var produtora = _mapper.Map<Produtora>(dto);
                _produtoraRepository.Add(produtora);
                return CreatedAtAction(nameof(GetById), new { Id = produtora.Id}, produtora);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateProdutoraDTO dto)
        {
            if (ModelState.IsValid)
            {
                var produtora = _mapper.Map<Produtora>(dto);
                _produtoraRepository.Update(produtora);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = _produtoraRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
