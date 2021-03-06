using Data.Helpers;
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

            //if (gamePes)
            //{
            //    query = query.AsNoTracking().Where(u => u.GamePes == true);
            //}
            //else
            //{
            //    query = query.AsNoTracking().Where(u => u.GamePes == false);
            //}

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

        public async Task<IEnumerable<User>> BuscaUsers()
        {
            IQueryable<User> query = _context.Users;

            query = query.AsNoTracking().OrderBy(u => u.Login);

            return await query.ToArrayAsync();
        }

        public async Task<User> BuscaUserPorId(int id)
        {
            IQueryable<User> query = _context.Users;

            query = query.AsNoTracking().Where(u => u.Id == id);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<User> BuscaUserPorLogin(string login)
        {
            IQueryable<User> query = _context.Users;

            query = query.AsNoTracking().Where(u => u.Login == login);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<User> BuscaUserPorEmail(string email)
        {
            IQueryable<User> query = _context.Users;

            query = query.AsNoTracking().Where(u => u.Email == email);

            return await query.FirstOrDefaultAsync();
        }
    }
}
