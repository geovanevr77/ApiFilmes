﻿using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace FilmesApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 0;

        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaFilmePorId), new {id = filme.Id},filme);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperaFilme([FromQuery] int skip = 0, [FromQuery] int take = 2)
        {
            return filmes.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int Id)
        {
            var filme = filmes.FirstOrDefault(filme => filme.Id == Id);
            if (filme == null) return NotFound();
            return Ok(filme);
        }
    }
}
