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
   public class PlayerAppRepository : IPlayerApp
    {

        private readonly DataContext _context;

        public PlayerAppRepository(DataContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<PlayerApp>> BuscaPlayersApp(bool incluirTime = false)
        {
            IQueryable<PlayerApp> query = _context.PlayersApp;


            query = query.AsNoTracking().OrderBy(u => u.Nome);


            if (incluirTime)
            {
                //Retorna Usuarios e os dados do seus respectivo Clube
                // query = query.AsNoTracking().OrderBy(u => u.Nome).Include(h => h.Time);
            }

            return await query.ToArrayAsync();
        }

        public async Task<PlayerApp> BuscaPlayerAppPorId(int id)
        {
            IQueryable<PlayerApp> query = _context.PlayersApp;

            query = query.AsNoTracking().OrderBy(p => p.Id).Where(p => p.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<PlayerApp> BuscaPlayerAppNome(string nome)
        {
            IQueryable<PlayerApp> query = _context.PlayersApp;

            query = query.AsNoTracking().Where(p => p.Nome.Equals(nome));

            return await query.FirstOrDefaultAsync(p => p.Nome == nome);
        }

        public async Task<PlayerApp> BuscaPlayerAppPorPsn(string psn)
        {
            IQueryable<PlayerApp> query = _context.PlayersApp;

            query = query.AsNoTracking().OrderBy(a => a.Psn).Where(p => p.Psn.Equals(psn));

            return await query.FirstOrDefaultAsync();
        }



    }
}
