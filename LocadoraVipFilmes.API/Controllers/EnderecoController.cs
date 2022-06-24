﻿using AutoMapper;
using LocadoraVipFilmes.API.DTOs.EnderecoDTO;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IMapper _mapper;

        public EnderecoController(IEnderecoRepository enderecoRepository, IMapper mapper)
        {
            _enderecoRepository = enderecoRepository ?? throw new ArgumentNullException(nameof(enderecoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            if (ModelState.IsValid)
            {
                var enderecos = _enderecoRepository.GetAll();

                if (enderecos.Count() > 0)
                    return Ok(_mapper.Map<IEnumerable<ReadEnderecoDTO>>(enderecos));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var endereco = _enderecoRepository.GetById(id);

                if (endereco != null)
                    return Ok(_mapper.Map<ReadEnderecoDTO>(endereco));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateEnderecoDTO dto)
        {
            if (ModelState.IsValid)
            {
                var endereco = _mapper.Map<Endereco>(dto);
                _enderecoRepository.Add(endereco);
                return CreatedAtAction(nameof(GetById), new { Id = endereco.Id }, endereco);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateEnderecoDTO dto)
        {
            if (ModelState.IsValid)
            {
                var endereco = _mapper.Map<Endereco>(dto);
                _enderecoRepository.Update(endereco);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = _enderecoRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
