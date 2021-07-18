using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.Context;
using Dominio.Dtos.User;
using Dominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace MyTeam.API.V1.Controllers
{
    /// <summary>
    /// Versao 1 do controlador de Users
    /// </summary>

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ICrud _crud;
        private readonly IUser _userRep;

        /// <summary>
        /// 
        /// </summary>
        /// /// /// <param name="crud"></param>
        /// <param name="userrep"></param>
        public UserController(IUser userrep, ICrud crud)
        {
            _crud = crud;
            _userRep = userrep;
        }

        /// <summary>
        /// Método responsável para retornar todos os usuarios cadastrados
        /// </summary>
        /// <returns></returns>
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _userRep.BuscaUsers());
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }
        /// <summary>
        /// Método responsável para retornar 1 usuário cadastrado, de acordo o seu login
        /// </summary>
        /// <returns></returns>
     
        [HttpGet("{login}")]
        public async Task<IActionResult> GetNome(string login)
        {
            try
            {
                return Ok(await _userRep.BuscaUserPorLogin(login));
            }
            catch (Exception e)
            {
               return Ok(e.Message);
            }
           
        }

        /// <summary>
        /// Método responsável para retornar 1 usuário cadastrado, de acordo o seu login
        /// </summary>
        /// /// <param name="email"></param>
        /// <returns></returns>
       
        [HttpGet("poremail/{email}")]
        public async Task<IActionResult> GetEmail(string email)
        {
            try
            {
                return Ok(await _userRep.BuscaUserPorEmail(email));
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }


        /// <summary>
        /// Método responsavel por adicionar um novo Usuário.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(UserDtoCreate user)
        {
            try
            {
                UserDtoCreateResult userresult;
                if (ModelState.IsValid)
                {
                    userresult = await _userRep.AdicionarUser(user);
                    return Ok(userresult);
                }
                return Ok("Dados do Usuário inválidos.");
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }

        /// <summary>
        /// Método responsavel por atualizar um Usuário
        /// </summary>
        ///  <param name="id"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, User user)
        {

            var validauser = await _userRep.BuscaUserPorId(id);

            if (validauser != null)
            {
                var validaLogin = await _userRep.BuscaUserPorLogin(user.Login);

                if (validaLogin == null || validauser.Login == user.Login)
                {
                    var validaEmail = await _userRep.BuscaUserPorEmail(user.Email);

                    if (validaEmail == null || validaEmail.Email == user.Email)
                    {
                        _crud.Update(user);
                        await _crud.SaveChangeAsync();
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

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletePorId(int id)
        {
            var user = await _userRep.BuscaUserPorId(id);

                if (user != null)
                {
                    _crud.Delete(user);
                    await _crud.SaveChangeAsync();
                    return Ok("Usuário excluido com sucesso");
                }   
            else
            {
                return Ok("Usuário não localizado.");
            }
        }
    }
}
