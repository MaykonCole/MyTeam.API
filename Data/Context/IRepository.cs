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

        #region Crud
        void Add<T>(T entidade) where T : class;

        void Update<T>(T entidade) where T : class;

        void Delete<T>(T entidade) where T : class;


        Task<bool> SaveChangeAsync();
        #endregion

        #region Game
        Task<IEnumerable<Game>> BuscaGamePorTime(int id, bool incluirTime = false);

        Task<IEnumerable<Game>> BuscaGamePorData(string data, int id);

        Task<Game> BuscaGamePorId(int id);

        #endregion

        #region PlayerApp
        Task<IEnumerable<PlayerApp>> BuscaPlayersApp(bool incluirTime = false);

        Task<PlayerApp> BuscaPlayerAppPorId(int id);
        Task<PlayerApp> BuscaPlayerAppPorPsn(string psn);
        Task<PlayerApp> BuscaPlayerAppNome(string nome);
        #endregion


        #region Player
        Task<PageList<Player>> BuscaPlayers(PageParams pageParams, bool incluirTime = false);

        Task<Player> BuscaPlayerPorId(int id);
        Task<Player> BuscaPlayerPorPsn(string psn);
        Task<Player> BuscaPlayerNome(string nome);
        #endregion

        #region Team
        Task<IEnumerable<Team>> BuscaTimes(bool incluirTime = false, bool incluirPartidas = false, bool gamePes = true);
        Task<Team> BuscaTimePorId(int id);
        Task<Team> BuscaTimePorNome(string nome);
        Task<IEnumerable<Team>> BuscaTimePorLikeNome(string nome);
        Task<Team> BuscaTimePorEscudo(string escudo);
        #endregion


        #region User
        Task<IEnumerable<User>> BuscaUsers();

        Task<User> BuscaUserPorId(int id);
        Task<User> BuscaUserPorLogin(string login);
        Task<User> BuscaUserPorEmail(string email);

        #endregion

    }
}
