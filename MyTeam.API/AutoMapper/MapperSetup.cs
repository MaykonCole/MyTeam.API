using AutoMapper;
using Dominio.Dtos.Player;
using Dominio.Dtos.User;
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
            CreateMap<Player, PlayerDtoCreate>().ReverseMap();
            CreateMap<PlayerDtoCreate, PlayerDtoCreateResult>().ReverseMap();
            CreateMap<Player, PlayerDtoUpdate>().ReverseMap();
            CreateMap<PlayerDtoUpdate, PlayerDtoUpdateResult>().ReverseMap();
            CreateMap<PlayerDtoUpdateResult, Player>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();

        }
    }
}
