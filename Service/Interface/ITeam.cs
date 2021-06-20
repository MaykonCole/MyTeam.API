using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ITeam
    {
        Task<IEnumerable<Team>> BuscaTimes(bool incluirTime = false, bool incluirPartidas = false, bool gamePes = true);
        Task<Team> BuscaTimePorId(int id);
        Task<Team> BuscaTimePorNome(string nome);
        Task<IEnumerable<Team>> BuscaTimePorLikeNome(string nome);
        Task<Team> BuscaTimePorEscudo(string escudo);
    }
}
