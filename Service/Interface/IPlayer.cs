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
        Task<PlayerDto> BuscaPlayerPorPsn(string psn);
        Task<PlayerDto> BuscaPlayerPorNome(string nome);


        Task<PlayerDtoCreateResult> AdicionarPlayer(PlayerDtoCreate player);
        Task<PlayerDtoUpdateResult> AtualizarPlayer(int id, PlayerDtoUpdate player);

       Task ExcluirPorId(int id);
        Task ExcluirPorNome(string nome);
    }
}
