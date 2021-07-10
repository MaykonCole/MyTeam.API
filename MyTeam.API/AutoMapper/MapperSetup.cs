using AutoMapper;
using Dominio.Dtos.Player;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTeam.API.AutoMapper
{
    public class MapperSetup : Profile
    {
        public MapperSetup()
        {
            CreateMap<Player, PlayerDto>().ReverseMap();

        }
    }
}
