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

namespace MyTeam.API.V1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {

        private readonly IRepository _repo;
        private readonly IMapper _mapper;


        public GameController(IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }
    }
}
