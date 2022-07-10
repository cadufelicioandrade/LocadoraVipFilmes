using AutoMapper;
using LocadoraVipFilmes.API.DTOs.CidadeDTO;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "admin, funcionario")]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IMapper _mapper;

        public CidadeController(ICidadeRepository cidadeRepository, IMapper mapper)
        {
            _cidadeRepository = cidadeRepository ?? throw new ArgumentNullException(nameof(cidadeRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if (ModelState.IsValid)
            {
                var cidades = _cidadeRepository.GetCidades();

                if (cidades.Count() > 0)
                {
                    var readCidades = _mapper.Map<IEnumerable<ReadCidadeDTO>>(cidades);
                    return Ok(readCidades);
                }

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (ModelState.IsValid)
            {
                Cidade cidade = _cidadeRepository.GetCidadeById(id);

                if (cidade != null)
                {
                    var readCidade = _mapper.Map<ReadCidadeDTO>(cidade);
                    return Ok(readCidade);
                }

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateCidadeDTO dto)
        {
            if (ModelState.IsValid)
            {
                var cidade = _mapper.Map<Cidade>(dto);
                _cidadeRepository.Add(cidade);
                return CreatedAtAction(nameof(GetById), new { Id = cidade.Id }, cidade);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateCidadeDTO dto)
        {
            if (ModelState.IsValid)
            {
                var cidade = _mapper.Map<Cidade>(dto);
                _cidadeRepository.Update(cidade);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = _cidadeRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
