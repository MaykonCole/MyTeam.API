using Dominio.Dtos.User;
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
        Task<IEnumerable<UserDto>> BuscaUsers();
        Task<UserDto> BuscaUserPorId(int id);
        Task<UserDto> BuscaUserPorLogin(string login);
        Task<UserDto> BuscaUserPorEmail(string email);

        Task<UserDtoCreateResult> AdicionarUser(UserDtoCreate User);
        Task<UserDtoUpdateResult> AtualizarUser(int id, UserDtoUpdate User);

        Task ExcluirUserPorId(int id);
        Task ExcluirUserPorLogin(string nome);
    }
}
