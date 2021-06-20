using Data.Helpers;
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

        Task<Player> BuscaPlayerPorId(int id);
        Task<Player> BuscaPlayerPorPsn(string psn);
        Task<Player> BuscaPlayerNome(string nome);
    }
}
