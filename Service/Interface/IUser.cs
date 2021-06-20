using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IUser
    {
        Task<IEnumerable<User>> BuscaUsers();
        Task<User> BuscaUserPorId(int id);
        Task<User> BuscaUserPorLogin(string login);
        Task<User> BuscaUserPorEmail(string email);
    }
}
