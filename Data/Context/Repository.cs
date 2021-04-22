using Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class Repository : IRepository
    {

        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entidade) where T : class
        {
            _context.Add(entidade);
        }

        public void Delete<T>(T entidade) where T : class
        {
            _context.Remove(entidade);
        }

        public void Update<T>(T entidade) where T : class
        {
            _context.Update(entidade);
        }


        public async Task<bool> SaveChangeAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<IEnumerable<Player>> BuscaPlayers(bool incluirTime = false)
        {
            IQueryable<Player> query = _context.Players;


            query = query.AsNoTracking().OrderBy(u => u.Nome);


            if (incluirTime)
            {
                //Retorna Usuarios e os dados do seus respectivo Clube
                query = query.AsNoTracking().OrderBy(u => u.Nome).Include(h => h.Time);
            }

            return await query.ToArrayAsync();
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

            query = query.AsNoTracking().OrderBy(p => p.Nome);

            return await query.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Player> BuscaPlayerPorPsn(string psn)
        {
            IQueryable<Player> query = _context.Players;

            query = query.AsNoTracking().Where(p => p.Psn.Equals(psn));

            return await query.FirstOrDefaultAsync(p => p.Psn == psn);
        }

        public async Task<IEnumerable<Time>> BuscaTimes(bool incluirTime = false)
        {
            IQueryable<Time> query = _context.Times;

            query = query.AsNoTracking().OrderBy(u => u.NomeTime);

            if (incluirTime)
            {
                //Retorna Usuarios e os dados do seus respectivo Clube
                query = query.AsNoTracking().OrderBy(u => u.NomeTime);
            }

            return await query.ToArrayAsync();
        }

        public async Task<Time> BuscaTimePorId(int id)
        {
            IQueryable<Time> query = _context.Times;

            query = query.AsNoTracking().OrderBy(u => u.NomeTime);

            return await query.FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<Time> BuscaTimePorNome(string nome)
        {
            IQueryable<Time> query = _context.Times;

            query = query.AsNoTracking().Where(u => u.NomeTime.Equals(nome));

            return await query.FirstOrDefaultAsync(u => u.NomeTime == nome);
        }

        public async Task<Time> BuscaTimePorEscudo(string escudo)
        {
            IQueryable<Time> query = _context.Times;

            query = query.AsNoTracking().Where(u => u.LinkEscudo.Equals(escudo));

            return await query.FirstOrDefaultAsync(u => u.NomeTime == escudo);
        }


    }
}
