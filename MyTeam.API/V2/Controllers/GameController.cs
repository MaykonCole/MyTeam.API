using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.Context;
using Dominio.Dtos;
using Dominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Interface;

namespace MyTeam.API.V2.Controllers
{

    /// <summary>
    /// Versao 2 do controlador de Games
    /// </summary>
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    
    [ApiController]
    public class GameController : ControllerBase
    {

        private readonly ICrud _crud;
        private readonly IGame _repo;
        private readonly IMapper _mapper;


        /// <summary>
        /// 
        /// </summary>
        ///  /// <param name="crud"></param>
        /// <param name="repo"></param>
        /// <param name="mapper"></param>
        public GameController(ICrud crud, IGame repo, IMapper mapper)
        {
            _crud = crud;
            _repo = repo;
            _mapper = mapper;

        }


        /// <summary>
        /// Método responsável para retornar todos as Partidas de um Time!
        /// </summary>
        /// <returns></returns>
        // GET: api/<PlayerController>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {  
            return Ok(await _repo.BuscaGamePorTime(id));
        }

 /// <summary>
 /// 
 /// </summary>
 /// <param name="data"></param>
 /// <param name="teamId"></param>
 /// <returns></returns>
        [HttpGet("{data}/{teamId:int}")]
        public async Task<IActionResult> Get(string data, int teamId)
        {
            return Ok(await _repo.BuscaGamePorData(data, teamId));
        }


        /// <summary>
        /// Método responsavel por adicionar uma nova Partida.
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(Game game)
        {
            if (game != null)
            {
                _crud.Add(game);
                await _crud.SaveChangeAsync();
                return Ok("Partida contra o clube " + game.adversario + " cadastrada com sucesso.");

            }
            return BadRequest("Partida invalida!");
        }


        /// <summary>
        /// Método responsavel por atualizar uma Partida, de acordo o seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Game game)
        {
            var validagame = await _repo.BuscaGamePorId(id);

           
            if (validagame != null)
            {
                var validaData = await _repo.BuscaGamePorData(validagame.data, id);

                if (validaData != null)
                {
                    _crud.Update(game);
                    await _crud.SaveChangeAsync();
                    return Ok("Partida atualizada com sucesso.");
                }
                else
                {
                    return Ok("Partida não existe com esta data.");
                }
            }
            else
            {
                return Ok("Partida não encontrada.");
            }

        }

        ///// <summary>
        ///// Método responsavel por excluir um Partida, de acordo o seu ID.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        [HttpDelete("{id:int}/{teamId:int}")]
        public async Task<IActionResult> DeletePorId(int id, int teamId)
        {
            var game = await _repo.BuscaGamePorId(id);

            if (game.TeamId == teamId)
            {
                if (game != null)
                {
                    _crud.Delete(game);
                    await _crud.SaveChangeAsync();
                    return Ok("Partida excluida com sucesso");
                }
            }
            else
            {
                return Ok("Partida não é do clube logado.");
            }

            return BadRequest("Partida não encontrada!");
        }
    }
}
