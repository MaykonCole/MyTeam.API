using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IPlayerApp
    {
        Task<IEnumerable<PlayerApp>> BuscaPlayersApp(bool incluirTime = false);
        Task<PlayerApp> BuscaPlayerAppPorId(int id);
        Task<PlayerApp> BuscaPlayerAppPorPsn(string psn);
        Task<PlayerApp> BuscaPlayerAppNome(string nome);
    }
}
