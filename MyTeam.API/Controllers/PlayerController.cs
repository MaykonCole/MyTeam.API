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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyTeam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

     //   private readonly DataContext _context;

        private readonly IRepository _repo;
        private readonly IMapper _mapper;
        public PlayerController( IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }
        // GET: api/<PlayerController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var players = await _repo.BuscaPlayers(false);

           var playersdto = _mapper.Map<IEnumerable<PlayerDto>>(players);



                return Ok(playersdto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPorId(int id)
        {
            var player = await _repo.BuscaPlayerPorId(id);

            if (player == null) return BadRequest("Player com ID " + id + " não localizado.");


            var playerDto = _mapper.Map<PlayerDto>(player);

            return Ok(playerDto);
        }

        [HttpGet("pornome/{nome}")]
        public async Task<IActionResult> GetPorNomeQueryString(string nome)
        {
            var player = await _repo.BuscaPlayerNome(nome);

            if (player == null) return BadRequest("Player " + nome + " não localizado.");

            var playerDto = _mapper.Map<PlayerDto>(player);

            return Ok(playerDto);
        }

        [HttpGet("porpsn/{nome}")]
        public async Task<IActionResult> GetPorPsnQueryString(string nome)
        {
            var player = await _repo.BuscaPlayerPorPsn(nome);

            if (player == null) return BadRequest("PSN " + nome + " não localizado.");

            var playerDto = _mapper.Map<PlayerDto>(player);

            return Ok(playerDto);
        }

        [HttpGet("{nome}")]
        public async Task<IActionResult> GetPorNome(string nome)
        {
            var player = await _repo.BuscaPlayerNome(nome);

            if (player == null) return BadRequest("Player " + nome + " não localizado.");

            var playerDto = _mapper.Map<PlayerDto>(player);

            return Ok(playerDto);
        }

        [HttpPost]
        public async Task<IActionResult>  Post(Player player)
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

        [HttpDelete("excluirplayerporid/{id}")]
        public async Task<IActionResult> DeletePorId(int id)
        {
            var player = await _repo.BuscaPlayerPorId(id);


            if (player != null)
            {
                _repo.Delete(player);
                await _repo.SaveChangeAsync();
                return Ok(await _repo.BuscaPlayers());
            }

            return BadRequest("Player não encontrado!");

        }

        [HttpDelete("excluirplayerpornome/{nome}")]
        public async Task<IActionResult> DeletePorNome(string nome)
        {

            var player = await _repo.BuscaPlayerNome(nome);

            if (player != null)
            {
                _repo.Delete(player);
                await _repo.SaveChangeAsync();
                return Ok(await _repo.BuscaPlayers());
            }

            return BadRequest("Player não encontrado!");
        }

    }
}
