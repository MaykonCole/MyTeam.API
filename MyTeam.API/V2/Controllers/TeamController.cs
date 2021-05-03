using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Context;
using Dominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyTeam.API.V2.Controllers
{
    /// <summary>
    /// Versao 2 do controlador de Times
    /// </summary>

    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
      
        private readonly IRepository _repo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        public TeamController( IRepository repo)
        {
           
            _repo = repo;
        }

        /// <summary>
        /// Método responsável para retornar todos os Times.
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repo.BuscaTimes(true));
        }

        /// <summary>
        /// Método responsavel por retornar apenas um único Time, de acordo o seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPorId(int id)
        {
            var time = await _repo.BuscaTimePorId(id);

            if (time == null) return BadRequest("Time com ID " + id + " não localizado.");

            return Ok(time);
        }


        /// <summary>
        /// Método responsavel por retornar apenas um único Time, de acordo o seu Nome.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpGet("{nome}")]
        public async Task<IActionResult> GetPorNome(string nome)
        {
            var time = await _repo.BuscaTimePorNome(nome);

            if (time == null) return BadRequest("Time com Nome " + nome + " não localizado.");

            return Ok(time);
        }

        /// <summary>
        /// Método responsavel por adicionar um novo Time.
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(Team time)
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

        /// <summary>
        /// Método responsavel por atualizar um Time, de acordo o seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Team time)
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

    

        /// <summary>
        /// Método responsavel por excluir um Time, de acordo o seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("excluirtimeporid/{id}")]
        public async Task<IActionResult> DeletePorId(int id)
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

        /// <summary>
        /// Método responsavel por excluir um Time, de acordo o seu Nome.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpDelete("excluirtimepornome/{nome}")]
        public async Task<IActionResult> DeletePorNome(string nome)
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
