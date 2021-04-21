using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Context;
using Dominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyTeam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        private readonly DataContext _context;
        public PlayerController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<PlayerController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Players);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPorId(int id)
        {
            var player = _context.Players.FirstOrDefault(t => t.Id == id);

            if (player == null) return BadRequest("Player com ID " + id + " não localizado.");

            return Ok(player);
        }

        [HttpGet("pornome")]
        public IActionResult GetPorNomeQueryString(string nome)
        {
            var player = _context.Players.FirstOrDefault(t => t.Nome.Contains(nome));

            if (player == null) return BadRequest("Player " + nome + " não localizado.");

            return Ok(player);
        }

        [HttpGet("{nome}")]
        public IActionResult GetPorNome(string nome)
        {
            var player = _context.Players.FirstOrDefault(t => t.Nome.Contains(nome));

            if (player == null) return BadRequest("Player " + nome + " não localizado.");

            return Ok(player);
        }

        [HttpPost]
        public IActionResult Post(Player player)
        {
            if (player != null) {
                

               var validaNome = _context.Players.FirstOrDefault(t => t.Nome.Contains(player.Nome));

                if (validaNome == null)
                {
                    var validaPsn = _context.Players.FirstOrDefault(t => t.Psn.Contains(player.Psn));

                    if (validaPsn == null)
                    {
                        _context.Add(player);
                        _context.SaveChanges();
                        return Ok(_context.Players);
                    }
                    else
                    {
                        return Ok("Player já existe com esta PSN.");
                    }            
                }
                else
                {
                    return Ok("Player já existe com este nome.");
                }
            }
            return BadRequest("Player invalido!");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Player player)
        {

            var validaplayer = _context.Players.AsNoTracking().FirstOrDefault(t => t.Id == id);

            if (validaplayer != null)
            {
                _context.Update(player);
                _context.SaveChanges();
                return Ok(_context.Players);
            }

            return BadRequest("Player não encontrado!");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Player player)
        {

            var validaplayer = _context.Players.AsNoTracking().FirstOrDefault(t => t.Id == id);

            if (validaplayer != null)
            {
                _context.Update(player);
                _context.SaveChanges();

                return Ok(_context.Players);
            }

            return BadRequest("Player não encontrado!");
        }

        [HttpDelete("excluirplayerporid/{id}")]
        public IActionResult DeletePorId(int id)
        {
            var player = _context.Players.FirstOrDefault(t => t.Id == id);


            if (player != null)
            {
                _context.Remove(player);
                _context.SaveChanges();
                return Ok(_context.Players);
            }

            return BadRequest("Player não encontrado!");

        }

        [HttpDelete("excluirplayerpornome/{nome}")]
        public IActionResult DeletePorNome(string nome)
        {

            var player = _context.Players.FirstOrDefault(t => t.Nome == nome);

            if (player != null)
            {
                _context.Remove(player);
                _context.SaveChanges();
                return Ok(_context.Players);
            }

            return BadRequest("Player não encontrado!");
        }

    }
}
