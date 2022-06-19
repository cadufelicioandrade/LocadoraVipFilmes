﻿using AutoMapper;
using LocadoraVipFilmes.API.DTOs.AtorDTO;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    public class AtorController : ControllerBase
    {
        private readonly IAtorRepository _atorRepository;
        private readonly IMapper _mapper;

        public AtorController(IAtorRepository atorRepository, IMapper mapper)
        {
            _atorRepository = atorRepository ?? throw new ArgumentNullException(nameof(atorRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                var atores = await _atorRepository.GetAll();

                if (atores.Count() > 0)
                    return Ok(_mapper.Map<IEnumerable<ReadAtorDTO>>(atores));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var ator = await _atorRepository.GetById(id);

                if(ator != null)
                    return Ok(_mapper.Map<ReadAtorDTO>(ator));

                return Ok("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAtorDTO dto)
        {
            if (ModelState.IsValid)
            {
                var ator = _mapper.Map<Ator>(dto);
                _atorRepository.AdicionarFilmeAtor(ator);
                return CreatedAtAction(nameof(GetById), new { Id = ator.Id }, ator);
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateAtorDTO dto)
        {
            if (ModelState.IsValid)
            {
                var ator = _mapper.Map<Ator>(dto);
                _atorRepository.Update(ator);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status =  await _atorRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}
