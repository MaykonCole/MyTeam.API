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
   public class UserRepository : IUser
    {

        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
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
