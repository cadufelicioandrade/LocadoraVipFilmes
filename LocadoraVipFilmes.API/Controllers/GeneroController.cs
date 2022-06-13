﻿using AutoMapper;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVipFilmes.API.Controllers
{
    public class GeneroController : Controller
    {
        private readonly IGeneroRepository _generoRepository;
        private readonly IMapper _mapper;

        public GeneroController(IGeneroRepository generoRepository, IMapper mapper)
        {
            _generoRepository = generoRepository ?? throw new ArgumentNullException(nameof(generoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (ModelState.IsValid)
            {
                var generos = await _generoRepository.GetAll();

                if (generos.Count() > 0)
                    return Ok(generos);

                return NotFound("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                var genero = await _generoRepository.GetById(id);

                if (genero != null)
                    return Ok(genero);

                return NotFound("Nenhum iten localizado.");
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Genero genero)
        {
            if (ModelState.IsValid)
            {
                _generoRepository.Add(genero);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Genero genero)
        {
            if (ModelState.IsValid)
            {
                _generoRepository.Update(genero);
                return Ok();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var status = await _generoRepository.Delete(id);

                if (status)
                    return NoContent();

                return NotFound();
            }

            return BadRequest("Validar se todos campos estão corretos.");
        }
    }
}