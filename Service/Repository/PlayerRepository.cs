using AutoMapper;
using Data.Context;
using Data.Helpers;
using Dominio.Dtos.Player;
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
        private readonly ICrud _crud;
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        
        public PlayerRepository(ICrud crud, DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _crud = crud;
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

            if (query == null)
                throw new Exception("Lista vazia ou inválida.");


            return await PageList<Player>.CreateAsync(query, pageParams.PageNumber, pageParams.PageSize);
        }

        public async Task<PlayerDto> BuscaPlayerPorNome(string nome)
        {
           var players = _context.Players;
           var player = await players.AsNoTracking().FirstOrDefaultAsync(p => p.Nome.Equals(nome));

            //Validacoes
            if (player == null)
                throw new Exception("Jogador com Nome " + nome + " não foi localizado.");

            var playerdto = _mapper.Map<PlayerDto>(player);
            return playerdto;
        }

        public async Task<PlayerDto> BuscaPlayerPorId(int id)
        {
            var players = _context.Players;
            var player = await players.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

            //Validacoes
            if (player == null)
                throw new Exception("Jogador com ID " + id + " não foi localizado.");

            var playerdto = _mapper.Map<PlayerDto>(player);
            return playerdto;
        }

        public async Task<PlayerDto> BuscaPlayerPorPsn(string psn)
        {
            var players = _context.Players;
            var player = await players.AsNoTracking().FirstOrDefaultAsync(p => p.Psn.Equals(psn));

            //Validacoes
            if (player == null)
                throw new Exception("Jogador com PSN " + psn + " não foi localizado.");

            var playerdto = _mapper.Map<PlayerDto>(player);
            return playerdto;
        }

        public async Task<PlayerDtoCreateResult> AdicionarPlayer(PlayerDtoCreate playerDtoCreate)
        {
            var players = _context.Players;
            //Validacoes 
            if (playerDtoCreate == null)
                throw new Exception("Jogador NULO não pode ser adicionado");

            var validaPsn= await players.AsNoTracking().FirstOrDefaultAsync(p => p.Psn.Equals(playerDtoCreate.Psn));
            if (validaPsn != null)
                throw new Exception("Já existe um Player utilizando esta PSN : " + playerDtoCreate.Psn);

            var player = _mapper.Map<Player>(playerDtoCreate);

            _crud.Add(player);
            await _crud.SaveChangeAsync();

            var playerDtoResult = _mapper.Map<PlayerDtoCreateResult>(playerDtoCreate);

            return playerDtoResult;

        }

        public async Task<PlayerDtoUpdateResult> AtualizarPlayer(int id, PlayerDtoUpdate playerDtoUpdate)
        {
            var players = _context.Players;
            //Validacoes 
            if (playerDtoUpdate == null)
                throw new Exception("Jogador NULO não pode ser atualizado.");

           var playerexiste = await players.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

            if (playerexiste == null)
                throw new Exception("Jogador com ID " + id + " não existe.");

            playerexiste.Nome = playerDtoUpdate.Nome != null ? playerDtoUpdate.Nome : playerexiste.Nome;
            playerexiste.Celular = playerDtoUpdate.Celular != null ? playerDtoUpdate.Celular : playerexiste.Celular;
            playerexiste.PerfilPlayer = playerDtoUpdate.PerfilPlayer!= null ? playerDtoUpdate.PerfilPlayer: playerexiste.PerfilPlayer;
            playerexiste.PosicaoP = playerDtoUpdate.PosicaoP != null ? playerDtoUpdate.PosicaoP : playerexiste.PosicaoP;
            playerexiste.AtualizadoEm = DateTime.Now;

            _crud.Update(playerexiste);
            await _crud.SaveChangeAsync();

            var playerDtoResult = _mapper.Map<PlayerDtoUpdateResult>(playerexiste);

            return playerDtoResult;
        }

        public async Task ExcluirPorId(int id)
        {
            var players = _context.Players;
            var player =  await players.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

            if (player == null)
                throw new Exception("Jogador com ID " + id + " não existe.");

             _crud.Delete(player);
            await _crud.SaveChangeAsync();

        }

        public async Task ExcluirPorNome(string nome)
        {
            var players = _context.Players;
            var player = await players.AsNoTracking().FirstOrDefaultAsync(p => p.Nome == nome);

            if (player == null)
                throw new Exception("Jogador com Nome " + nome + " não existe.");

            _crud.Delete(player);
            await _crud.SaveChangeAsync();
        }
    }
}
