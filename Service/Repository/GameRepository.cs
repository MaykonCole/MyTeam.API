using Data.Context;
using Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository
{
    public class GameRepository : IGame
    {
        private readonly DataContext _context;
        public GameRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Game>> BuscaGamePorTime(int TeamId, bool incluirTime = false)
        {

            IQueryable<Game> query = _context.Games;

            query = query.AsNoTracking().OrderBy(u => u.data);

            query = query.AsNoTracking().Where(u => u.TeamId == TeamId);

            return await query.ToArrayAsync();

        }

        public async Task<IEnumerable<Game>> BuscaGamePorData(string data, int id)
        {
            IQueryable<Game> query = _context.Games;

            query = query.AsNoTracking().OrderBy(u => u.data);
            query = query.AsNoTracking().Where(u => u.data.Equals(data));
            query = query.AsNoTracking().Where(u => u.TeamId == id);

            return await query.ToArrayAsync();
        }

        public async Task<Game> BuscaGamePorId(int id)
        {
            IQueryable<Game> query = _context.Games;

            query = query.AsNoTracking().OrderBy(p => p.Id).Where(p => p.Id == id);

            return await query.FirstOrDefaultAsync();
        }
    }
}
