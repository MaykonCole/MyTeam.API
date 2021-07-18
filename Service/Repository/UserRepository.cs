using AutoMapper;
using Data.Context;
using Dominio.Dtos.User;
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
   public class UserRepository : IUser
    {

        private readonly ICrud _crud;
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserRepository(ICrud crud, DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _crud = crud;
        }
        public async Task<IEnumerable<UserDto>> BuscaUsers()
        {
            var usuarios =  _context.Users;

            var todosusuarios = await usuarios.AsNoTracking().Where(x => x.Ativo == true).ToListAsync();

            if (todosusuarios.Count <= 0)
                throw new Exception("Nenhum Usuário foi encontrado.");

            var usuariosdto = _mapper.Map<IEnumerable<UserDto>>(todosusuarios);

            return usuariosdto;
        }

        public async Task<UserDto> BuscaUserPorId(int id)
        {
            var usuarios = _context.Users;

            var user = await usuarios.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
                throw new Exception("Usuário com ID : " + id + " não localizado.");
            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }
        public async Task<UserDto> BuscaUserPorLogin(string login)
        {
            var usuarios = _context.Users;

           var user = await usuarios.AsNoTracking().FirstOrDefaultAsync(u => u.Login == login);

            if (user == null)
                throw new Exception("Usuário com Login : " + login + " não localizado.");

            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }
        public async Task<UserDto> BuscaUserPorEmail(string email)
        {
            var usuarios = _context.Users;

            var user = await usuarios.AsNoTracking().FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
                throw new Exception("Usuário com Email : " + email + " não localizado.");

            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }

        public async Task<UserDtoCreateResult> AdicionarUser(UserDtoCreate userDtoCreate)
        {
            var usuarios = _context.Users;

            if (userDtoCreate == null)
                throw new Exception("Usuário NULO não pode ser adicionado.");

            var validaLogin = await usuarios.AsNoTracking().FirstOrDefaultAsync(u => u.Login.Equals(userDtoCreate.Login));
            if (validaLogin != null)
                throw new Exception("Já existe um Usuário utilizando este Login : " + userDtoCreate.Login);

            var validaEmail = await usuarios.AsNoTracking().FirstOrDefaultAsync(u => u.Email.Equals(userDtoCreate.Email));
            if (validaEmail != null)
                throw new Exception("Já existe um Usuário utilizando este Email : " + userDtoCreate.Email);

            userDtoCreate.CriadooEm = DateTime.Now;
            userDtoCreate.Ativo = true;

            var user = _mapper.Map<User>(userDtoCreate);

            _crud.Add(user);
            await _crud.SaveChangeAsync();

            var userDtoResult = _mapper.Map<UserDtoCreateResult>(userDtoCreate);

            return userDtoResult;
        }

        public Task<UserDtoUpdateResult> AtualizarUser(int id, UserDtoUpdate User)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirUserPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirUserPorLogin(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
