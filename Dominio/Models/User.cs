using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class User
    {
        public User()
        {

        }

        public User(int id, string login, string senha, string perfilUsuario, DateTime dataCadastro, DateTime dataAtualizacao)
        {
            Id = id;
            Login = login;
            Senha = senha;
            PerfilUsuario = perfilUsuario;
            DataCadastro = dataCadastro;
            DataAtualizacao = dataAtualizacao;
        }

        [Key]
        public int Id{ get; set; }
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Nome deve conter no minimo 2 caracteres")]
        [Required]
        public string Login { get; set; }

        [StringLength(20, MinimumLength = 6, ErrorMessage = "Senha deve conter no minimo 6 caracteres")]
        [DataType(DataType.Password)]
        [Required]
        public string Senha { get; set; }
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Perfil Usuario deve conter no minimo 2 caracteres")]
        [Required]
        public string PerfilUsuario { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime DataAtualizacao{ get; set; } = DateTime.Now;
        public int? PlayerId { get; set; }
        public Player Player { get; set; }


    }
}
