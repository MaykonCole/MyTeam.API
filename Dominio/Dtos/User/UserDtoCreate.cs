using Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dtos.User
{
    public class UserDtoCreate
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Login deve conter entre 2 e 20 caracteres.")]
        [Required]
        public string Login { get; set; }

        [StringLength(20, MinimumLength = 6, ErrorMessage = "Senha deve conter entre 6 e 30 caracteres.")]
        [DataType(DataType.Password)]
        [Required]
        public string Senha { get; set; }

        [StringLength(30, MinimumLength = 6, ErrorMessage = "Email deve conter entre 6 e 30 caracteres.")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime CriadooEm { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [Required]
        public bool ResponsavelTime { get; set; }
    }
}
