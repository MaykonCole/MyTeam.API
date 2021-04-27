﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.Context;
using Data.Helpers;
using Dominio.Dtos;
using Dominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

  
        private readonly IRepository _repo;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="mapper"></param>
        public PlayerController( IRepository repo, IMapper mapper)
        {
            _repo = repo;
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
            var players = await _repo.BuscaPlayers(pageParams, false);

           var playersdto = _mapper.Map<IEnumerable<PlayerDto>>(players);



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
            var player = await _repo.BuscaPlayerPorId(id);

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
            var player = await _repo.BuscaPlayerNome(nome);

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
            var player = await _repo.BuscaPlayerPorPsn(psn);

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
        public async Task<IActionResult> Post(Player player)
        {
            if (player != null) {
                

               var validaNome = await _repo.BuscaPlayerNome(player.Nome);

                if (validaNome == null)
                {
                    var validaPsn = await _repo.BuscaPlayerPorPsn(player.Psn);

                    if (validaPsn == null)
                    {
                        _repo.Add(player);
                       await _repo.SaveChangeAsync();
                        return Created($"/api/player/{player.Id}", player);
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
        public async Task<IActionResult> Put(int id, Player player)
        {
            var validaplayer = await _repo.BuscaPlayerPorId(id);

            if (validaplayer != null)
            {
                var validaNome = await _repo.BuscaPlayerNome(player.Nome);

                if (validaNome == null)
                {
                    var validaPsn = await _repo.BuscaPlayerPorPsn(player.Psn);

                    if (validaPsn == null)
                    {
                        _repo.Update(player);
                        await _repo.SaveChangeAsync();
                        return Created($"/api/player/{player.Id}", player);
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

            return BadRequest("Player não encontrado!");

        }

        /// <summary>
        /// Método responsavel por atualizar um Player, de acordo o seu ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, Player player)
        {

            var validaplayer = await _repo.BuscaPlayerPorId(id);

            if (validaplayer != null)
            {
                var validaNome = await _repo.BuscaPlayerNome(player.Nome);

                if (validaNome == null)
                {
                    var validaPsn = await _repo.BuscaPlayerPorPsn(player.Psn);

                    if (validaPsn == null)
                    {
                        _repo.Update(player);
                        await _repo.SaveChangeAsync();
                        return Created($"/api/player/{player.Id}", player);
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
            var player = await _repo.BuscaPlayerPorId(id);


            if (player != null)
            {
                _repo.Delete(player);
                await _repo.SaveChangeAsync();
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

            var player = await _repo.BuscaPlayerNome(nome);

            if (player != null)
            {
                _repo.Delete(player);
                await _repo.SaveChangeAsync();
                return Ok(player);
            }

            return BadRequest("Player não encontrado!");
        }

    }
}
