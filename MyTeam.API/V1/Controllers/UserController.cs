using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Context;
using Dominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyTeam.API.V1.Controllers
{
    /// <summary>
    /// Versao 1 do controlador de Users
    /// </summary>

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRepository _repo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        public UserController(IRepository repo)
        { 
            _repo = repo;
        }

        /// <summary>
        /// Método responsável para retornar todos os usuarios cadastrados
        /// </summary>
        /// <returns></returns>
        // GET: api/<PlayerController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repo.BuscaUsers());
        }

        /// <summary>
        /// Método responsável para retornar 1 usuário cadastrado, de acordo o seu login
        /// </summary>
        /// <returns></returns>
        // GET: api/<PlayerController>
        [HttpGet("{login}")]
        public async Task<IActionResult> GetNome(string login)
        {
            return Ok(await _repo.BuscaUserPorLogin(login));
        }

        /// <summary>
        /// Método responsável para retornar 1 usuário cadastrado, de acordo o seu login
        /// </summary>
        /// <returns></returns>
        // GET: api/<PlayerController>
        [HttpGet("poremail/{email}")]
        public async Task<IActionResult> GetEmail(string email)
        {
            return Ok(await _repo.BuscaUserPorEmail(email));
        }


        /// <summary>
        /// Método responsavel por adicionar um novo Usuário.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(User user)
        {
            if (user != null)
            {
                var validaLogin = await _repo.BuscaUserPorLogin(user.Login);

                if (validaLogin == null)
                {
                    var validaEmail = await _repo.BuscaUserPorEmail(user.Email);

                    if (validaEmail == null)
                    {
                        _repo.Add(user);
                        await _repo.SaveChangeAsync();
                        return Ok("Usuario " + user.Login + " cadastrado com sucesso.");
                    }
                    else
                    {
                        return Ok("Usuário já existe com este Email.");
                    }
                }
                else
                {
                    return Ok("Usuario ja cadastrado com este Login.");
                }
            }
            return BadRequest("Usuário invalido!");
        }

        /// <summary>
        /// Método responsavel por atualizar um Usuário
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Put(int id, User user)
        {

            var validauser = await _repo.BuscaUserPorId(id);

            if (validauser != null)
            {
                var validaLogin = await _repo.BuscaUserPorLogin(user.Login);

                if (validaLogin == null)
                {
                    var validaEmail = await _repo.BuscaUserPorEmail(user.Email);

                    if (validaEmail == null)
                    {
                        _repo.Update(user);
                        await _repo.SaveChangeAsync();
                        return Ok("Usuario " + user.Login + " atualizado com sucesso.");
                    }
                    else
                    {
                        return Ok("Usuário já existe com este Email.");
                    }
                }
                else
                {
                    return Ok("Usuario ja cadastrado com este Login.");
                }
            }
            return BadRequest("Usuário invalido!");
        }

        ///// <summary>
        ///// Método responsavel por excluir um Usuario, de acordo o seu ID.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletePorId(int id)
        {
            var user = await _repo.BuscaUserPorId(id);

                if (user != null)
                {
                    _repo.Delete(user);
                    await _repo.SaveChangeAsync();
                    return Ok("Partida excluida com sucesso");
                }   
            else
            {
                return Ok("Usuário não localizado.");
            }
          
        }
    }
}
