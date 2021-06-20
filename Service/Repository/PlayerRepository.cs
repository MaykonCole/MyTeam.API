using Data.Context;
using Data.Helpers;
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
    public class PlayerRepository : IPlayer
    {

        private readonly DataContext _context;
        public PlayerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<PageList<Player>> BuscaPlayers(PageParams pageParams, bool incluirTime = false)
        {

            IQueryable<Player> query = _context.Players;


            query = query.AsNoTracking().OrderBy(u => u.Nome);


            if (incluirTime)
            {
                //Retorna Usuarios e os dados do seus respectivo Clube
                query = query.AsNoTracking().OrderBy(u => u.Nome).Include(h => h.Team);
            }

            if (!string.IsNullOrEmpty(pageParams.Nome))
            {
                query = query.Where(player => player.Nome.ToUpper().Contains(pageParams.Nome.ToUpper()));
            }

            if (!string.IsNullOrEmpty(pageParams.Psn))
            {
                query = query.Where(player => player.Psn.ToUpper().Contains(pageParams.Psn.ToUpper()));
            }

            if (pageParams.PlayerAtivo != null)
            {
                query = query.Where(player => player.PlayerAtivo == (pageParams.PlayerAtivo != 0));
            }


            return await PageList<Player>.CreateAsync(query, pageParams.PageNumber, pageParams.PageSize);

            //return await query.ToListAsync();
        }

        public async Task<Player> BuscaPlayerNome(string nome)
        {
            IQueryable<Player> query = _context.Players;

            query = query.AsNoTracking().Where(p => p.Nome.Equals(nome));

            return await query.FirstOrDefaultAsync(p => p.Nome == nome);
        }

        public async Task<Player> BuscaPlayerPorId(int id)
        {
            IQueryable<Player> query = _context.Players;

            query = query.AsNoTracking().OrderBy(p => p.Id).Where(p => p.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Player> BuscaPlayerPorPsn(string psn)
        {
            IQueryable<Player> query = _context.Players;

            query = query.AsNoTracking().OrderBy(a => a.Psn).Where(p => p.Psn.Equals(psn));

            return await query.FirstOrDefaultAsync();
        }
    }
}
