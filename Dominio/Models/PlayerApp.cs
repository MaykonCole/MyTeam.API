using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class PlayerApp
    {
        public PlayerApp()
        {

        }

        public PlayerApp(string nome, string psn, string posicao, string telefone, string procuraTime)
        {
            Nome = nome;
            Psn = psn;
            Posicao = posicao;
            Telefone = telefone;
            ProcuraTime = procuraTime;
          
        }

        [Key]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Nome deve conter no minimo 2 caracteres")]
        [Required]
        public string Nome { get; set; }
        [StringLength(20, MinimumLength = 2, ErrorMessage = "PSN deve conter no minimo 2 caracteres")]
        [Required]
        public string Psn { get; set; }

        [Required]
        public string Posicao { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Nome do time adversário deve conter no minimo 10 caracteres")]
        public string Telefone { get; set; }

        [Required]
        public string ProcuraTime { get; set; }
        //public int? TimeId { get; set; }
        //public Time Time { get; set; }
    }
}
