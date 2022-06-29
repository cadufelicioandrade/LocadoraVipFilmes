using AutoMapper;
using LocadoraVipFilmes.API.DTOs.ClienteDTO;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "admin, funcionario")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteController(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if (ModelState.IsValid)
            {
                var clientes = _clienteRepository.GetAll();

                if (clientes.Count() > 0)
                    return Ok(_mapper.Map<IEnumerable<ReadClienteDTO>>(clientes));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var cliente = _clienteRepository.GetById(id);

                if (cliente != null)
                    return Ok(_mapper.Map<ReadClienteDTO>(cliente));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateClienteDTO dto)
        {
            if (ModelState.IsValid)
            {
                var cliente = _mapper.Map<Cliente>(dto);
                _clienteRepository.Add(cliente);
                return CreatedAtAction(nameof(GetById), new { Id = cliente.Id }, cliente);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateClienteDTO dto)
        {
            if (ModelState.IsValid)
            {
                var cliente = _mapper.Map<Cliente>(dto);
                _clienteRepository.Update(cliente);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = _clienteRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
