using AutoMapper;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    public class EstadoController : ControllerBase
    {
        private readonly IEstadoRepository _estadoRepository;
        private readonly IMapper _mapper;

        public EstadoController(IEstadoRepository estadoRepository, IMapper mapper)
        {
            _estadoRepository = estadoRepository ?? throw new ArgumentNullException(nameof(estadoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                var estados = await _estadoRepository.GetAll();

                if (estados.Count() > 0)
                    return Ok(estados);

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var estado = await _estadoRepository.GetById(id);

                if (estado != null)
                    return Ok(estado);

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Estado estado)
        {
            if (ModelState.IsValid)
            {
                _estadoRepository.Add(estado);
                return CreatedAtAction(nameof(GetById), new { Id = estado.Id }, estado);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Estado estado)
        {
            if (ModelState.IsValid)
            {
                _estadoRepository.Update(estado);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = await _estadoRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
