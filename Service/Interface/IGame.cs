using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IGame
    {
        Task<IEnumerable<Game>> BuscaGamePorTime(int id, bool incluirTime = false);

        Task<IEnumerable<Game>> BuscaGamePorData(string data, int id);

        Task<Game> BuscaGamePorId(int id);
    }
}
