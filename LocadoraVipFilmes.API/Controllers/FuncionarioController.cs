using AutoMapper;
using LocadoraVipFilmes.API.DTOs.FuncionarioDTO;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipfuncionarios.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "admin, funcionario")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IMapper _mapper;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository, IMapper mapper)
        {
            _funcionarioRepository = funcionarioRepository ?? throw new ArgumentNullException(nameof(funcionarioRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if (ModelState.IsValid)
            {
                var funcionarios = _funcionarioRepository.GetFuncionarios();

                if (funcionarios.Count() > 0)
                {
                    var readFuncionarios = _mapper.Map<IEnumerable<ReadFuncionarioDTO>>(funcionarios);
                    return Ok(readFuncionarios);
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
                var funcionario = _funcionarioRepository.GetFuncionario(id);

                if (funcionario != null)
                {
                    var readFuncionario = _mapper.Map<ReadFuncionarioDTO>(funcionario);
                    return Ok(readFuncionario);
                }

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateFuncionarioDTO dto)
        {
            if (ModelState.IsValid)
            {
                var funcionario = _mapper.Map<Funcionario>(dto);
                _funcionarioRepository.Add(funcionario);
                return CreatedAtAction(nameof(GetById), new { Id = funcionario.Id }, funcionario);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateFuncionarioDTO dto)
        {
            if (ModelState.IsValid)
            {
                var funcionario = _mapper.Map<Funcionario>(dto);
                _funcionarioRepository.Update(funcionario);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = _funcionarioRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
