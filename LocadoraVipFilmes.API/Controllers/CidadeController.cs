using AutoMapper;
using LocadoraVipFilmes.API.DTOs.CidadeDTO;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
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
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                var cidades = await _cidadeRepository.GetAll();

                if (cidades.Count() > 0)
                    return Ok(_mapper.Map<IEnumerable<ReadCidadeDTO>>(cidades));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var cidade = await _cidadeRepository.GetById(id);

                if (cidade != null)
                    return Ok(_mapper.Map<ReadCidadeDTO>(cidade));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCidadeDTO dto)
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
        public async Task<IActionResult> Update([FromBody] UpdateCidadeDTO dto)
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
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = await _cidadeRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
