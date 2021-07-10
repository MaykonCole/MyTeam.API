using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dtos.User
{
    public class UserDtoUpdate
    {
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;
        public bool ResponsavelTime { get; set; }
    }
}
