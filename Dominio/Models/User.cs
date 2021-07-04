using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class User : Base
    {
        public User()
        {

        }

        public User(int id, string login, string senha, string email, bool responsavel)
        {
            Id = id;
            Login = login;
            Senha = senha;
            Email = email;
            ResponsavelTime = responsavel;
          
        }

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Nome deve conter no minimo 2 caracteres")]
        [Required]
        public string Login { get; set; }

        [StringLength(20,  MinimumLength = 6, ErrorMessage = "Senha deve conter no minimo 6 caracteres")]
        [DataType(DataType.Password)]
        [Required]
        public string Senha { get; set; }

        [StringLength(30, MinimumLength = 6, ErrorMessage = "")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        public int? PlayerId { get; set; }
        public Player Player { get; set; }
        public bool ResponsavelTime { get; set; }


    }
}
