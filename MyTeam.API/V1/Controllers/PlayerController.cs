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

           var playersdto = _mapper.Map<IEnumerable<PlayerDto>>(players);

            Response.AddPagination(players.AtualPagina, players.TamanhoPagina, players.ItemTotal, players.TotalPaginas);

                return Ok(playersdto);
        }

        /// <summary>
        /// Método responsavel por retornar apenas um único Player, de acordo o seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPorId(int id)
        {
            var player = await _playerRep.BuscaPlayerPorId(id);

            if (player == null) return BadRequest("Player com ID " + id + " não localizado.");

            var playerDto = _mapper.Map<PlayerDto>(player);

            return Ok(playerDto);
        }


        /// <summary>
        /// Método responsavel por retornar apenas um único Player, de acordo o seu Nome.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpGet("pornome/{nome}")]
        public async Task<IActionResult> GetPorNomeQueryString(string nome)
        {
            var player = await _playerRep.BuscaPlayerNome(nome);

            if (player == null) return BadRequest("Player " + nome + " não localizado.");

            var playerDto = _mapper.Map<PlayerDto>(player);

            return Ok(playerDto);
        }

        /// <summary>
        /// Método responsavel por retornar apenas um único Player, de acordo a sua PSN.
        /// </summary>
        /// <param name="psn"></param>
        /// <returns></returns>
        [HttpGet("porpsn/{psn}")]
        public async Task<IActionResult> GetPorPsnQueryString(string psn)
        {
            var player = await _playerRep.BuscaPlayerPorPsn(psn);

            if (player == null) return BadRequest("PSN " + psn + " não localizado.");

            var playerDto = _mapper.Map<PlayerDto>(player);

            return Ok(playerDto);
        }



        /// <summary>
        /// Método responsavel por adicionar um novo Player.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(PlayerDtoCreate player)
        {
            if (player != null) {
                

               var validaNome = await _playerRep.BuscaPlayerNome(player.Nome);

                if (validaNome == null)
                {
                    var validaPsn = await _playerRep.BuscaPlayerPorPsn(player.Psn);

                    if (validaPsn == null)
                    {
                        _crud.Add(player);
                       await _crud.SaveChangeAsync();
                        return Ok("Player cadastrado com sucesso.");
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

        /// <summary>
        /// Método responsavel por atualizar um Player, de acordo o seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PlayerDtoUpdate player)
        {
            var validaplayer = await _playerRep.BuscaPlayerPorId(id);

            if (validaplayer != null)
            {
                var validaNome = await _playerRep.BuscaPlayerNome(player.Nome);

                if (validaNome == null || validaplayer.Nome == player.Nome)
                {
                        _crud.Update(player);
                        await _crud.SaveChangeAsync();
                        return Ok("Player atualizado com sucesso.");
                }
                else
                {
                    return Ok("Player já existe com este nome.");
                }
            }
            return BadRequest("Player não encontrado!");

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
                var validaNome = await _playerRep.BuscaPlayerNome(player.Nome);

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
        public async Task<IActionResult> DeletePorId(int id)
        {
            var player = await _playerRep.BuscaPlayerPorId(id);

            if (player != null)
            {
                _crud.Delete(player);
                await _crud.SaveChangeAsync();
                return Ok(player);
            }

            return BadRequest("Player não encontrado!");

        }

        /// <summary>
        /// Método responsavel por excluir um Player, de acordo o seu Nome.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        [HttpDelete("excluirplayerpornome/{nome}")]
        public async Task<IActionResult> DeletePorNome(string nome)
        {
            var player = await _playerRep.BuscaPlayerNome(nome);

            if (player != null)
            {
                _crud.Delete(player);
                await _crud.SaveChangeAsync();
                return Ok(player);
            }
            return BadRequest("Player não encontrado!");
        }

    }
}
