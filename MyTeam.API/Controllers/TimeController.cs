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
        //private readonly DataContext _context;
        private readonly IRepository _repo;
        public TimeController( IRepository repo)
        {
           
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repo.BuscaTimes(true));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPorId(int id)
        {
            var time = await _repo.BuscaTimePorId(id);

            if (time == null) return BadRequest("Time com ID " + id + " não localizado.");

            return Ok(time);
        }

        [HttpGet("pornome")]
        async Task<IActionResult>  GetPorNomeQueryString(string nome)
        {
            var time = await _repo.BuscaTimePorNome(nome);

            if (time == null) return BadRequest("Time com Nome " + nome + " não localizado.");

            return Ok(time);
        }

        [HttpGet("{nome}")]
        async Task<IActionResult> GetPorNome(string nome)
        {
            var time = await _repo.BuscaTimePorNome(nome);

            if (time == null) return BadRequest("Time com Nome " + nome + " não localizado.");

            return Ok(time);
        }

        [HttpPost]
        async Task<IActionResult> Post(Time time)
        {
            if (time != null)
            {
                var validaNome = await _repo.BuscaTimePorNome(time.NomeTime);

                if (validaNome == null)
                {
                    var validaEscudo = await _repo.BuscaTimePorEscudo(time.LinkEscudo);

                    if (validaEscudo == null)
                    {
                        _repo.Add(time);
                        await _repo.SaveChangeAsync();
                        return Ok(await _repo.BuscaTimes());
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
        async Task<IActionResult> Put(int id, Time time)
        {
            var validatime = await _repo.BuscaTimePorId(id);

            if (validatime != null)
            {
                _repo.Update(time);
               await _repo.SaveChangeAsync();
                return Ok(await _repo.BuscaTimes());
            }

            return BadRequest("Time não encontrado!");

        }

        [HttpPatch("{id}")]
        async Task<IActionResult> Patch(int id, Time time)
        {

            var validatime = await _repo.BuscaTimePorId(id);

            if (validatime != null)
            {
                _repo.Update(time);
                await _repo.SaveChangeAsync();
                return Ok(await _repo.BuscaTimes());
            }

            return BadRequest("Timer não encontrado!");
        }

        [HttpDelete("excluirtimeporid/{id}")]
        async Task<IActionResult> DeletePorId(int id)
        {
             var time = await _repo.BuscaTimePorId(id);

            if (time != null)
            {
                _repo.Delete(time);
                await _repo.SaveChangeAsync();
                return Ok(await _repo.BuscaTimes());
            }

            return BadRequest("Time não encontrado!");
        }

        [HttpDelete("excluirtimepornome/{nome}")]
        async Task<IActionResult> DeletePorNome(string nome)
        {
            var time = await _repo.BuscaTimePorNome(nome);

            if (time != null)
            {
                _repo.Delete(time);
                await _repo.SaveChangeAsync();
                return Ok(await _repo.BuscaTimes());
            }

            return BadRequest("Time não encontrado!");
        }


    }
}
