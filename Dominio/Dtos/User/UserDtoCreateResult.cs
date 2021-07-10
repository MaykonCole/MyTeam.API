using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dtos.User
{
    public class UserDtoCreateResult
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime CriadooEm { get; set; }
        public bool ResponsavelTime { get; set; }
    }
}
