using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.Context;
using Data.Helpers;
using Dominio.Dtos;
using Dominio.Dtos.Player;
using Dominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyTeam.API.V1.Controllers
{
    /// <summary>
    /// Versao 1 do controlador de Players
    /// </summary>

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly ICrud _crud;
        private readonly IPlayer _playerRep;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// /// <param name="crud"></param>
        /// <param name="playerrep"></param>
        /// <param name="mapper"></param>
        public PlayerController(ICrud crud, IPlayer playerrep, IMapper mapper)
        {
            _crud = crud;
            _playerRep = playerrep;
            _mapper = mapper;

        }

        /// <summary>
        /// Método responsável para retornar todos os Jogadores!
        /// </summary>
        /// <returns></returns>
        // GET: api/<PlayerController>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]PageParams pageParams)
        {
            var players = await _playerRep.BuscaPlayers(pageParams, false);

            Response.AddPagination(players.AtualPagina, players.TamanhoPagina, players.ItemTotal, players.TotalPaginas);

            return Ok(players);
        }

        /// <summary>
        /// Método responsavel por retornar apenas um único Player, de acordo o seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPorId(int id)
        {
            try
            {
                var playerDto = await _playerRep.BuscaPlayerPorId(id);
                return Ok(playerDto);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }


        /// <summary>
        /// Método responsavel por retornar apenas um único Player, de acordo o seu Nome.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpGet("pornome/{nome}")]
        public async Task<IActionResult> GetPorNome(string nome)
        {
            try
            {
                //Busca o jogador
                var playerDto = await _playerRep.BuscaPlayerPorNome(nome);
                // Retornar o PlayerDTO
                return Ok(playerDto);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        /// <summary>
        /// Método responsavel por retornar apenas um único Player, de acordo a sua PSN.
        /// </summary>
        /// <param name="psn"></param>
        /// <returns></returns>
        [HttpGet("porpsn/{psn}")]
        public async Task<IActionResult> GetPorPsn(string psn)
        {
            try
            {
                //Busca o jogador
                var playerDto = await _playerRep.BuscaPlayerPorPsn(psn);
                // Retornar o PlayerDTO
                return Ok(playerDto);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }



        /// <summary>
        /// Método responsavel por adicionar um novo Player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(PlayerDtoCreate player)
        {
            try
            {
                PlayerDtoCreateResult playerresult;
                if (ModelState.IsValid)
                {
                    playerresult = await _playerRep.AdicionarPlayer(player);
                    return Ok(playerresult);
                }
                return Ok("Dados do Player inválidos.");
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        /// <summary>
        /// Método responsavel por atualizar um Player, de acordo o seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PlayerDtoUpdate player)
        {
            try
            {
                PlayerDtoUpdateResult playerresult;
                if (ModelState.IsValid)
                {
                    playerresult = await _playerRep.AtualizarPlayer(id, player);
                    return Ok(playerresult);
                }
                return Ok("Dados do Player inválidos.");
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }

        }

        /// <summary>
        /// Método responsavel por atualizar um Player, de acordo o seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, PlayerDtoUpdate player)
        {

            var validaplayer = await _playerRep.BuscaPlayerPorId(id);

            if (validaplayer != null)
            {
                var validaNome = await _playerRep.BuscaPlayerPorNome(player.Nome);

                if (validaNome == null)
                {
                        _crud.Update(player);
                        await _crud.SaveChangeAsync();
                        return Created($"/api/player/{player.Id}", player);
                }
                else
                {
                    return Ok("Player já existe com este nome.");
                }
            }

            return BadRequest("Player não encontrado!");
        }

        /// <summary>
        /// Método responsavel por excluir um Player, de acordo o seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("excluirplayerporid/{id}")]
        public IActionResult DeletePorId(int id)
        {
            try
            {
                _playerRep.ExcluirPorId(id);
                return Ok("Jogador de ID " + id + " excluído com sucesso.");
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }

        }

        /// <summary>
        /// Método responsavel por excluir um Player, de acordo o seu Nome.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpDelete("excluirplayerpornome/{nome}")]
        public IActionResult DeletePorNome(string nome)
        {
            try
            {
                _playerRep.ExcluirPorNome(nome);
                return Ok("Jogador de Nome " + nome + " excluído com sucesso.");
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }

        }

    }
}
