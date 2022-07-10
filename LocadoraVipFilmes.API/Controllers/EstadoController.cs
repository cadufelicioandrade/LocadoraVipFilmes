using AutoMapper;
using LocadoraVipFilmes.API.DTOs.EstadoDTO;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "admin, funcionario")]
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
        public IActionResult GetAll()
        {
            if (ModelState.IsValid)
            {
                List<Estado> estados = _estadoRepository.GetEstados();

                if (estados.Count() > 0)
                    return Ok(_mapper.Map<IEnumerable<ReadEstadoDTO>>(estados));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var estado = _estadoRepository.GetEstadoById(id);

                if (estado != null)
                {
                    var readEstado = _mapper.Map<ReadEstadoDTO>(estado);
                    return Ok(readEstado);
                }

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateEstadoDTO dto)
        {
            if (ModelState.IsValid)
            {
                var estado = _mapper.Map<Estado>(dto);
                _estadoRepository.Add(estado);
                return CreatedAtAction(nameof(GetById), new { Id = estado.Id }, estado);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateEstadoDTO dto)
        {
            if (ModelState.IsValid)
            {
                var estado = _mapper.Map<Estado>(dto);
                _estadoRepository.Update(estado);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = _estadoRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
