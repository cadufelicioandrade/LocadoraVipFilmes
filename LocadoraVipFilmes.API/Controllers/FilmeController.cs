using AutoMapper;
using LocadoraVipFilmes.API.DTOs.FilmeDTO;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "admin, funcionario")]
    public class FilmeController : ControllerBase
    {
        private readonly IFilmeRepository _filmeRepository;
        private readonly IMapper _mapper;

        public FilmeController(IFilmeRepository filmeRepository, IMapper mapper)
        {
            _filmeRepository = filmeRepository ?? throw new ArgumentNullException(nameof(filmeRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if (ModelState.IsValid)
            {
                var filmes = _filmeRepository.GetAll();

                if (filmes.Count() > 0)
                    return Ok(_mapper.Map<IEnumerable<ReadFilmeDTO>>(filmes));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var filme = _filmeRepository.GetById(id);

                if (filme != null)
                    return Ok(_mapper.Map<ReadFilmeDTO>(filme));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateFilmeDTO dto)
        {
            if (ModelState.IsValid)
            {
                var filme = _mapper.Map<Filme>(dto);
                _filmeRepository.Add(filme);
                return CreatedAtAction(nameof(GetById), new { Id = filme.Id }, filme);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateFilmeDTO dto)
        {
            if (ModelState.IsValid)
            {
                var filme = _mapper.Map<Filme>(dto);
                _filmeRepository.Update(filme);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = _filmeRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

    }
}