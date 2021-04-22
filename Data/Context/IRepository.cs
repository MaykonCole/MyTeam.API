using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public interface IRepository
    {
        void Add<T>(T entidade) where T : class;

        void Update<T>(T entidade) where T : class;

        void Delete<T>(T entidade) where T : class;


        Task<bool> SaveChangeAsync();

        Task<IEnumerable<Player>> BuscaPlayers(bool incluirTime = false);

        Task<Player> BuscaPlayerPorId(int id);
        Task<Player> BuscaPlayerPorPsn(string psn);
        Task<Player> BuscaPlayerNome(string nome);

        Task<IEnumerable<Time>> BuscaTimes(bool incluirTime = false);
        Task<Time> BuscaTimePorId(int id);
        Task<Time> BuscaTimePorNome(string nome);
        Task<Time> BuscaTimePorEscudo(string escudo);

    }
}
