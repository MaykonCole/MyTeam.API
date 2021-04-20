using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace MyTeam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {

        public List<Time> Times = new List<Time>()
        {
           new Time()
            {
               Id = 1,
               NomeTime = "Huntersx",
               LinkEscudo = "https://3.bp.blogspot.com/-EYC1tYqWkkg/W0GN7cbUVrI/AAAAAAAAANc/Te0De9OprMwT61tUFLHBMgMk8Vnib8ViwCLcBGAs/s1600/352.jpg",
               DataCadastro = DateTime.Now,
               DataAtualizacao = null,
            },
           new Time()
           {
               Id = 2,
               NomeTime = "Bleuz",
               LinkEscudo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTqjj6BQUYM_7q65lgATuGvXPLKo6iaJJYIe_bhrc3eRokzozfLKF73Odj_T-rgYGLoEUU&usqp=CAU",
               DataCadastro = DateTime.Now,
               DataAtualizacao = null,
            },
           new Time()
            {
               Id = 3,
               NomeTime = "Raça Gaucha",
               LinkEscudo = "data:image/jpeg;base64,/9j/4AAUXGRobHx0eGRoYIiAYGysmICUwLjczNS03LS8t=",
               DataCadastro = DateTime.Now,
               DataAtualizacao = null,
            }

        };
        public TimeController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Times);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPorId(int id)
        {
            var time = Times.FirstOrDefault(t => t.Id == id);

            if (time == null) return BadRequest("Time com ID " + id + " não localizado.");

            return Ok(time);
        }

        [HttpGet("pornome")]
        public IActionResult GetPorNomeQueryString(string nome)
        {
            var time = Times.FirstOrDefault(t => t.NomeTime.Contains(nome));

            if (time == null) return BadRequest("Time com Nome " + nome + " não localizado.");

            return Ok(time);
        }

        [HttpGet("{nome}")]
        public IActionResult GetPorNome(string nome)
        {
            var time = Times.FirstOrDefault(t => t.NomeTime.Contains(nome));

            if (time == null) return BadRequest("Time com Nome " + nome + " não localizado.");

            return Ok(time);
        }

        [HttpPost]
        public IActionResult Post(Time time)
        {



            return Ok(Times);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Time time)
        {



            return Ok(Times);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Time time)
        {



            return Ok(Times);
        }

        [HttpDelete("excluirtimeporid/{id}")]
        public IActionResult DeletePorId(int id)
        {



            return Ok(Times);
        }

        [HttpDelete("excluirtimepornome/{nome}")]
        public IActionResult DeletePorNome(string nome)
        {



            return Ok(Times);
        }


    }
}
