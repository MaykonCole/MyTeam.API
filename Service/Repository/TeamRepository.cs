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
    public class TeamRepository : ITeam
    {
        private readonly DataContext _context;
        public TeamRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Team>> BuscaTimes(bool incluirJogadores = false, bool incluirPartidas = false, bool gamePes = true)
        {
            IQueryable<Team> query = _context.Times;

            query = query.AsNoTracking().OrderBy(u => u.NomeTime);

            if (incluirJogadores)
            {
                //Retorna Usuarios e os dados do seus respectivo Clube
                query = query.AsNoTracking().OrderBy(u => u.NomeTime).Include(h => h.Players);

            }

            if (incluirPartidas)
            {
                query = query.AsNoTracking().OrderBy(u => u.NomeTime).Include(h => h.Games);
            }

            if (gamePes)
            {
                query = query.AsNoTracking().Where(u => u.GamePes == true);
            }
            else
            {
                query = query.AsNoTracking().Where(u => u.GamePes == false);
            }

            return await query.ToArrayAsync();
        }

        public async Task<Team> BuscaTimePorId(int id)
        {
            IQueryable<Team> query = _context.Times;

            query = query.AsNoTracking().OrderBy(u => u.NomeTime).Where(h => h.Id == id);



            return await query.FirstOrDefaultAsync();
        }

        public async Task<Team> BuscaTimePorNome(string nome)
        {
            IQueryable<Team> query = _context.Times;

            query = query.AsNoTracking().OrderBy(u => u.NomeTime).Where(u => u.NomeTime.Equals(nome));

          

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Team>> BuscaTimePorLikeNome(string nome)
        {
            IQueryable<Team> query = _context.Times;

            query = query.AsNoTracking().OrderBy(u => u.NomeTime).Where(u => u.NomeTime.Contains(nome));



            return await query.ToArrayAsync();
        }

        public async Task<Team> BuscaTimePorEscudo(string escudo)
        {
            IQueryable<Team> query = _context.Times;

            query = query.AsNoTracking().OrderBy(a => a.LinkEscudo).Where(u => u.LinkEscudo.Equals(escudo));

            return await query.FirstOrDefaultAsync();
        }

    }
}
