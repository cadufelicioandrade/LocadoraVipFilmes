using AutoMapper;
using LocadoraVipFilmes.API.DTOs.GeneroDTO;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroRepository _generoRepository;
        private readonly IMapper _mapper;

        public GeneroController(IGeneroRepository generoRepository, IMapper mapper)
        {
            _generoRepository = generoRepository ?? throw new ArgumentNullException(nameof(generoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if (ModelState.IsValid)
            {
                var generos = _generoRepository.GetAll();

                if (generos.Count() > 0)
                    return Ok(_mapper.Map<IEnumerable<ReadGeneroDTO>>(generos));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var genero = _generoRepository.GetById(id);

                if (genero != null)
                    return Ok(_mapper.Map<ReadGeneroDTO>(genero));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateGeneroDTO dto)
        {
            if (ModelState.IsValid)
            {
                var genero = _mapper.Map<Genero>(dto);
                _generoRepository.Add(genero);
                return CreatedAtAction(nameof(GetById), new { Id = genero.Id }, genero);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateGeneroDTO dto)
        {
            if (ModelState.IsValid)
            {
                var genero = _mapper.Map<Genero>(dto);
                _generoRepository.Update(genero);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = _generoRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
