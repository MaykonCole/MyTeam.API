using Data.Helpers;
using Dominio.Dtos;
using Dominio.Dtos.Player;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IPlayer
    {
        Task<PageList<Player>> BuscaPlayers(PageParams pageParams, bool incluirTime = false);

        Task<PlayerDto> BuscaPlayerPorId(int id);
        Task<Player> BuscaPlayerPorPsn(string psn);
        Task<Player> BuscaPlayerPorNome(string nome);
    }
}
