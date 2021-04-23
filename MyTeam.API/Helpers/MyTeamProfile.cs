using AutoMapper;
using Dominio.Dtos;
using Dominio.Models;
using MyTeam.API.Helpers;

namespace Dominio.Helpers
{
    public class MyTeamProfile : Profile
    {
        public MyTeamProfile()
        {
            CreateMap<Player, PlayerDto>()
                .ForMember(
                dest => dest.Idade,
                opt => opt.MapFrom(src => src.DataNascimento.PegarIdadeAtual())

                );
                
        }

    }
}
