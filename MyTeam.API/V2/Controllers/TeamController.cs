using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Context;
using Dominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Interface;

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
        private readonly ICrud _crud;
        private readonly ITeam _repo;


        /// <summary>
        /// 
        /// </summary>
        ///  /// <param name="crud"></param>
        /// <param name="repo"></param>
        public TeamController(ICrud crud, ITeam repo)
        {
            _repo = repo;
            _crud = crud;
        }

      


        /// <summary>
        /// Método responsavel por retornar todos os TImes - Perfil FIFA FALSE ou Perfil PES TRUE
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        [HttpGet("{game:bool}")]
        public async Task<IActionResult> Get(bool game)
        {
            return Ok(await _repo.BuscaTimes(false, false, game));
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
        /// Método responsavel por retornar os Times que possui caracteres iguais aos repassados. LIKE SQL.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpGet("like/{nome}")]
        public async Task<IActionResult> GetPorLikeNome(string nome)
        {
            var time = await _repo.BuscaTimePorLikeNome(nome);


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
                        _crud.Add(time);
                        await _crud.SaveChangeAsync();
                        return Ok("Time adicionado com sucesso.");
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
                _crud.Update(time);
               await _crud.SaveChangeAsync();
                return Ok("Time atualizado com sucesso.");
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
                _crud.Delete(time);
                await _crud.SaveChangeAsync();
                return Ok("Time excluido com sucesso.");
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
                _crud.Delete(time);
                await _crud.SaveChangeAsync();
                return Ok("Time excluido com sucesso.");
            }

            return BadRequest("Time não encontrado!");
        }

    }
}
