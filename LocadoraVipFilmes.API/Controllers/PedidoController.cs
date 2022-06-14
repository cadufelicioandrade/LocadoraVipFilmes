using AutoMapper;
using LocadoraVipFilmes.API.DTOs.PedidoDTO;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public PedidoController(IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository ?? throw new ArgumentNullException(nameof(pedidoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                var pedidos = await _pedidoRepository.GetAll();

                if (pedidos.Count() > 0)
                    return Ok(_mapper.Map<IEnumerable<ReadPedidoDTO>>(pedidos));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var pedido = await _pedidoRepository.GetById(id);

                if (pedido != null)
                    return Ok(_mapper.Map<ReadPedidoDTO>(pedido));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreatePedidoDTO dto)
        {
            if (ModelState.IsValid)
            {
                var pedido = _mapper.Map<Pedido>(dto);
                _pedidoRepository.Add(pedido);
                return CreatedAtAction(nameof(GetById), new { Id = pedido.Id }, pedido);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdatePedidoDTO dto)
        {
            if (ModelState.IsValid)
            {
                var pedido = _mapper.Map<Pedido>(dto);
                _pedidoRepository.Update(pedido);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = await _pedidoRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
