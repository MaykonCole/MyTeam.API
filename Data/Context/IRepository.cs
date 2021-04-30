using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Helpers;

namespace Data.Context
{
    public interface IRepository
    {
        void Add<T>(T entidade) where T : class;

        void Update<T>(T entidade) where T : class;

        void Delete<T>(T entidade) where T : class;


        Task<bool> SaveChangeAsync();



        Task<IEnumerable<PlayerApp>> BuscaPlayersApp(bool incluirTime = false);

        Task<PlayerApp> BuscaPlayerAppPorId(int id);
        Task<PlayerApp> BuscaPlayerAppPorPsn(string psn);
        Task<PlayerApp> BuscaPlayerAppNome(string nome);



        Task<PageList<Player>> BuscaPlayers(PageParams pageParams, bool incluirTime = false);

        Task<Player> BuscaPlayerPorId(int id);
        Task<Player> BuscaPlayerPorPsn(string psn);
        Task<Player> BuscaPlayerNome(string nome);

        Task<IEnumerable<Team>> BuscaTimes(bool incluirTime = false);
        Task<Team> BuscaTimePorId(int id);
        Task<Team> BuscaTimePorNome(string nome);
        Task<Team> BuscaTimePorEscudo(string escudo);

    }
}
