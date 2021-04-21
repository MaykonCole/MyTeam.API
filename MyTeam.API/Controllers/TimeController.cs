using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Context;
using Dominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyTeam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly DataContext _context;
        public TimeController(DataContext context)
        {
            _context = context;
        }
        

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Times);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPorId(int id)
        {
            var time = _context.Times.FirstOrDefault(t => t.Id == id);

            if (time == null) return BadRequest("Time com ID " + id + " não localizado.");

            return Ok(time);
        }

        [HttpGet("pornome")]
        public IActionResult GetPorNomeQueryString(string nome)
        {
            var time = _context.Times.FirstOrDefault(t => t.NomeTime.Contains(nome));

            if (time == null) return BadRequest("Time com Nome " + nome + " não localizado.");

            return Ok(time);
        }

        [HttpGet("{nome}")]
        public IActionResult GetPorNome(string nome)
        {
            var time = _context.Times.FirstOrDefault(t => t.NomeTime.Contains(nome));

            if (time == null) return BadRequest("Time com Nome " + nome + " não localizado.");

            return Ok(time);
        }

        [HttpPost]
        public IActionResult Post(Time time)
        {
            if (time != null)
            {

                var validaNome = _context.Times.FirstOrDefault(t => t.NomeTime.Contains(time.NomeTime));

                if (validaNome == null)
                {
                    var validaEscudo = _context.Times.FirstOrDefault(t => t.LinkEscudo.Contains(time.LinkEscudo));

                    if (validaEscudo == null)
                    {
                        _context.Add(time);
                        _context.SaveChanges();
                        return Ok(_context.Times);
                    }
                    else
                    {
                        return Ok("Escudo já existe para um outro time.");
                    }
                }
                else
                {
                    return Ok("Time já existe com este nome.");
                }
            }
            return BadRequest("Time invalido!");



        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Time time)
        {
            var validatime = _context.Players.AsNoTracking().FirstOrDefault(t => t.Id == id);

            if (validatime != null)
            {
                _context.Update(time);
                _context.SaveChanges();

                return Ok(_context.Times);
            }

            return BadRequest("Time não encontrado!");

        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Time time)
        {

            var validatime = _context.Times.AsNoTracking().FirstOrDefault(t => t.Id == id);

            if (validatime != null)
            {
                _context.Update(time);
                _context.SaveChanges();

                return Ok(_context.Times);
            }

            return BadRequest("Timer não encontrado!");


        }

        [HttpDelete("excluirtimeporid/{id}")]
        public IActionResult DeletePorId(int id)
        {
            var time = _context.Times.FirstOrDefault(t => t.Id == id);

            if (time != null)
            {
                _context.Remove(time);
                _context.SaveChanges();
                return Ok(_context.Times);
            }

            return BadRequest("Time não encontrado!");
        }

        [HttpDelete("excluirtimepornome/{nome}")]
        public IActionResult DeletePorNome(string nome)
        {

            var time = _context.Times.FirstOrDefault(t => t.NomeTime == nome);

            if (time != null)
            {
                _context.Remove(time);
                _context.SaveChanges();
                return Ok(_context.Times);
            }

            return BadRequest("Time não encontrado!");
        }


    }
}
