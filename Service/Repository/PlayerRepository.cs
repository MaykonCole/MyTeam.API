using AutoMapper;
using Data.Context;
using Data.Helpers;
using Dominio.Dtos.Player;
using Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Service.Interface;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository
{
    public class PlayerRepository : IPlayer
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public PlayerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
          _mapper = mapper;
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
        }

        public async Task<Player> BuscaPlayerPorNome(string nome)
        {
           var players = _context.Players;
           var player = await players.AsNoTracking().FirstOrDefaultAsync(p => p.Nome.Equals(nome));
            if (player == null)
                throw new Exception("Jogador com Nome " + nome + " não foi localizado.");
            return player;
        }

        public async Task<PlayerDto> BuscaPlayerPorId(int id)
        {
            var players = _context.Players;

            var player = await players.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

            if (player == null)
                throw new Exception("Jogador com ID " + id + " não foi localizado.");

            var playerdto = _mapper.Map<PlayerDto>(player);

            return playerdto;
        }

        public async Task<Player> BuscaPlayerPorPsn(string psn)
        {
            var players = _context.Players;
            var player = await players.AsNoTracking().FirstOrDefaultAsync(p => p.Nome.Equals(psn));
            if (player == null)
                throw new Exception("Jogador com PSN " + psn + " não foi localizado.");
            return player;
        }
    }
}
